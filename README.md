# Binarization

## Description
This project is a hybrid application written in C# and assembly that performs image binarization. The application utilizes both C# for the graphical user interface and higher-level operations, and assembly for efficient image processing. It supports multi-threading to improve performance on multi-core processors.  
<br>

## Features
### Image Binarization: 
Convert images to black and white using a specified threshold.
### Multi-threading: 
Take advantage of multiple CPU cores for faster processing.
### Hybrid Implementation: 
Leverages the performance of assembly code with the flexibility of C#.
### User Interface: 
Simple GUI for loading images and adjusting binarization settings.
<br><br>

## Installation
### Clone the repository:
git clone https://github.com/agatoneq/Binarization.git
<br><br>

## Usage
Make sure JAAsm.dll is located in the specified path or update the path in the [DllImport] attribute.

### Run the application:
Launch the application executable from Visual Studio or the build directory.
### Load an image:
Click the "Pick Image" button and select an image file.
### Adjust settings:
Set the binarization threshold using the trackbars for both C# and assembly implementations.
Adjust the number of threads using the thread bar.
### Perform binarization:
Select either "C#" or "Asm" from the dropdown menu.
Click the "Confirm" button to binarize the image using the selected method.
### View and save results:
The binarized image will be displayed. Save the result if desired.
