# Introduction To Programming

## Introduction

## Requirements

For this project, you will need:

- Visual Studio (Community Edition is fine)
- .NET 6.0 LTS (Long Term Support)

You will need to download the C# workload for Visual Studio. During installation, select the `.NET desktop development` workload.

If you skipped past the workload selection, you can install this by opening `Visual Studio Installer`, selecting your installation of Visual Studio, and clicking `Modify`. Then, install the `.NET desktop development` workload.

## Getting Started

### Downloading the Project

To download the project, you can either:

- Download the project as a zip file
- Clone it via Git or GitHub Desktop

To download the project as a zip file, click the green "Code" button and select "Download ZIP". Once downloaded, extract the zip file to a folder of your choice.

To clone the project via Git or GitHub Desktop, click the green "Code" button and copy the URL. Then, open Git Bash or GitHub Desktop and run the following command:

```bash
git clone <url>
```

### Opening the Project

To open the project, open the `IntroductionToProgramming.sln` file in Visual Studio.

Alternatively, you can open the solution file by double-clicking it in File Explorer.
From this point forward, you can see it in your recent projects list in Visual Studio.

## What you will learn

- How to use Visual Studio
- How to run a C# application
- Variables and Conditionals

## The Parking Application

You have been hired as a new developer at your favourite event. They have given you the task to develop a parking application for their parking lot. The application will be used by the parking lot attendant to keep track of the cars in the parking lot.

Some elements have already been prepared ahead of time by the previous team, so a decent amount of UI work has already been done for you. You will be focusing on the backend of the application.

Do not worry about an actual payment system, the application only needs to display the amount of money that the customer needs to pay. The attendant will collect the money from the customer.

### Quick Test

The first order of business is to test what functions the application already supports.
Feel free to play around with the application and see what it can do. Once you are done, you can close the application.

## The Parking Lot

As you could see, so far the team has only managed to implement the car parking functionality. To make the application more useful, you will need to add support for motorbikes and caravans.

For simplicity, all vehicles take up a single parking slot. However, they are charged different rates. The parking lot charges the following rates:

- Cars: €2.50 per day
- Motorbikes: €1.50 per day
- Caravans: €2.50 per day

Keep in mind that caravans are (usually) towed by a car. Maybe there is a Quality of Life improvement that you can make here?

### Creating a new element

To add a new element to the application, you will need to add a new button to the UI. This button will be used to park the vehicle in the parking lot. To do this, you will need to:

- Open the Winform in Designer mode
  - Right-click the Winform and select "View Designer"
- Open the Toolbox
  - At the top of the screen, select View -> Toolbox
- Click and drag a `Button` Element onto the Winform
  - TIP: Rename the button in the properties window to something meaningful. IE: `Caravan_Button`
- Create a `On_Click` event handler for the button
  - TIP: Double-click the button to create the event handler

In this handler, you can add the code that will excute when the button is clicked. Use the car button as a reference.

### Releasing Vehicles

The parking lot attendant needs to be able to release vehicles from the parking lot. This means that the attendant needs to be able to select a vehicle and release it from the parking lot.

Once a vehicle has been released, the number of available slots should increase by one.

### Limiting vehicle count

The parking lot has a limited amount of space. The parking lot can only hold 10 vehicles at a time. If the parking lot is full, the application should not allow the attendant to park any more vehicles.

### Taxes

On top of the parking fee, the parking lot needs to collect VAT. For this service, the VAT rate is 21%. This is included in the price, but the application needs to display the amount of VAT that is collected.

Your task is to dust off your math skills and display the amount of VAT collected in a text box. At the end of this section, you need to have the following:

- The price EXCLUDING VAT
- A text box that displays the amount of VAT collected
- A total amount of money that the customer needs to pay

This should be displayed in the same order.

## Credits and Permission

Car Icon: [Freepik](https://www.freepik.com) from [Flaticon](https://www.flaticon.com/)

Motorbike Icon: [Freepik](https://www.freepik.com) from [Flaticon](https://www.flaticon.com/)

Caravan Icon: [Freepik](https://www.freepik.com) from [Flaticon](https://www.flaticon.com/)

## License

This project is licensed under the UNLICENSED License - see the [LICENSE.txt](LICENSE.txt) file for details.
