#include <LiquidCrystal.h>
#define TEMP_INTERVAL 500
#define CONN_INTERVAL 1500

// Initialize the library with the numbers of the interface pins
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
float temp = 0;
unsigned long tempPreviousMillis = 0;
unsigned long connPreviousMillis = 0;

byte memChar[8] = {
  0b00000,
  0b01110,
  0b11011,
  0b01010,
  0b11011,
  0b01010,
  0b11011,
  0b01110
};

byte termChar[8] = {
  0b00100,
  0b01110,
  0b01010,
  0b01010,
  0b01110,
  0b11111,
  0b11111,
  0b01110
};

void setup() {
  // Initialize the serial port
  Serial.begin(9600);

  // Initialize the lcd
  lcd.createChar(0, memChar);
  lcd.createChar(1, termChar);
  lcd.begin(16, 2);
  lcd.print("Air Temp: ");
  lcd.setCursor(15, 0);
  lcd.write(uint8_t(1));
  lcd.setCursor(0, 1);
  lcd.print("Mem: ");
  lcd.setCursor(15, 1);
  lcd.write(byte(0));
}

void loop() {
  // Update the temperature every INTERVAL ms
  if(millis() - tempPreviousMillis > TEMP_INTERVAL) {
    lcd.setCursor(10,0);
    temp = 5.0*analogRead(A0)*100.0/1024.0;
    lcd.print(temp, 1);
    lcd.print(" ");
    tempPreviousMillis = millis();
  }

  if(Serial.available() > 0) {
    connPreviousMillis = millis();
    if(millis() - connPreviousMillis < CONN_INTERVAL) {
      int i = Serial.parseInt();
      // Turn the value into GB from MB
      float memValue = i/1000.0;
      lcd.setCursor(5, 1);
      lcd.print(memValue, 1);
      lcd.print(" GB  ");
    }
  }

  // Check if the connection is lost
  if(millis() - connPreviousMillis > CONN_INTERVAL) {
    lcd.setCursor(5, 1);
    lcd.print("no conn.");
  }
  
}

