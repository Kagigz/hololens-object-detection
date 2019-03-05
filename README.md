# Object Detection on HoloLens

This sample shows how to perform Object Detection using the Microsoft Custom Vision API.

![exampleResult](https://github.com/Kagigz/hololens-object-detection/blob/master/holo%20object%20detection.jpg)

*In this example, the Custom Vision model is trained to recognize bananas and cans*

## How to use

### Step 1: Create your Custom Vision - Object Detection project

**Note:** To complete this step, you need to have Azure account. You can create one for free [here](https://azure.microsoft.com/free/).

- Create a new [Computer Vision service](https://azure.microsoft.com/en-us/services/cognitive-services/computer-vision/)
- Go to [customvision.ai](https://www.customvision.ai)
- Create a new project, and select Object Detection as the project type
- Upload training images (for each object you want to detect, you need to provide at least 15 images where it appears)
- Tag the objects in each image
- Train your Custom Vision model
- Set the current iteration as default
- In the settings, get the Prediction key & endpoint

### Step 2: Update the sample with your own Custom Vision model

- Download the sample
- Open it in Unity
- In the Scripts folder, open CustomVisionAnalyzer.cs
- Update the values of the prediction key and prediction endpoint with the ones you got in the previous step
- Build the project
- Open the generated Visual Studio solution
- Build & deploy to your HoloLens

### Step 3: Test on HoloLens

- Make sure you have objects recognized by your Custom Vision model at hand
- Once the app is ready (after the "Made with Unity" splash screen), make the tap gesture while looking at your target object(s)
- The tags & probabilities will appear next to the recognized objects

