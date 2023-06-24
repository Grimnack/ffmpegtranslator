# FFmpegTranslator

## launch the project 
open the solution (.sln) in visual studio with adminsitrator rights
launch the project with IIS Express it will open a browser with the swagger interface.

## Test 1 
```json
{
  "inputPath": "test_input1.mp4",
  "duration": 60.0,
  "width": 1920,
  "height": 1080,
  "outputPath": "test_output1.mp4",
  "text": "I’m sOoOo good at this game! xD",
  "x": 200,
  "y": 100,
  "fontSize": 64,
  "fontColorHex": "0xFFFFFF",
  "startTime": 23.0,
  "endTime": 40.0
}
```

## Test 2 
```json
{
  "inputPath": "test_input2.mp4",
  "duration": 60.0,
  "width": 1920,
  "height": 1080,
  "outputPath": "test_output2.mp4",
  "text": "Brutal, Savage, Rekt",
  "x": 0,
  "y": 0,
  "fontSize": 48,
  "fontColorHex": "0x000000",
  "startTime": 0.0,
  "endTime": 60.0
}
```

## Test 3 
```json
{
  "inputPath": "test_input3.mp4",
  "duration": 60.0,
  "width": 1920,
  "height": 1080,
  "outputPath": "test_output3.mp4",
  "text": "RIP",
  "x": 100,
  "y": 200,
  "fontSize": 32,
  "fontColorHex": "0xFFFFFF",
  "startTime": 24.0,
  "endTime": 75.0
}
```

## Test 4 
```json
{
  "inputPath": "test_input4.mp4",
  "duration": 60.0,
  "width": 1920,
  "height": 1080,
  "outputPath": "test_output4.mp4",
  "text": "RIP",
  "x": 100,
  "y": 9999,
  "fontSize": 48,
  "fontColorHex": "0x777777",
  "startTime": 24.0,
  "endTime": 48.0
}
```

## Disclaimer 
I didn't include inputpath and outputpath validation but we can imaginate checking if the input file exist and if the format of input and output is handled by FFmpeg