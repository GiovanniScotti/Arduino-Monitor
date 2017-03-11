# Arduino Monitor

This is a simple project to send usage information of your computer to your Arduino using serial communication.

## How It Works

A small and straightforward .NET application works as a server to send information to a usb-connected Arduino board.
The Arduino board is interfaced with an Hitachi-like 16x2 display in order to visualize the above-mentioned information.
Moreover a LM35 is used to measure the air temperature inside the case, therefore it should be properly positioned.

1. First of all, follow the schematic (not uploaded yet!) to set the circuit up;
1. Connect your Arduino and upload the provided sketch;
1. Open the "Arduino Monitor" application;
1. Click "Connect" after setting the serial port and the baud rate;
1. Enjoy!

## Known Limitations

* Only RAM usage is taken into account, so far.
