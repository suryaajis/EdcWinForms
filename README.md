# EDCWinForm

**EDCWinForm** is a Windows Forms application built with C# that integrates with an EDC (Electronic Data Capture) device from Taiwan. It listens to messages from RabbitMQ and performs corresponding EDC actions like payment, cancel, and settlement.

## Features

- Windows Forms interface
- Integration with Taiwan EDC device via SDK
- Listens to RabbitMQ for incoming messages
- Executes EDC actions based on received message

## How It Works

1. The application runs a background RabbitMQ listener.
2. When a message is received, it is parsed to determine the required EDC action.
3. The EDC SDK is used to communicate with the connected EDC device.
4. Results can be processed or sent back to the POS system.

## Requirements

- Windows OS
- .NET Framework 4.7.2 or higher
- RabbitMQ server
- Taiwan EDC device and SDK
- Visual Studio (for development)
