# CAIT - Revan Clock

To run this code clone this project to whatever directory you would like, and open the `Revan.sln` file with visual studio.
Then click on the `start` button at the top of the window. This will bring up the command-prompt where you will be able to type in the time in a 24-hour format (HH:MM:SS).

Another option to run the code would be to go to the release tab on Github, then download the binary for release `0.0.1` and run it.

To customize the output of the code, go to the `Program.cs` file and toggle some of the comments I've written. You have will the ability to:
- Change the color of the bulb.
- Change the amount of bulbs per row.
- Change the color of the quarter bulbs.
- Change the time parser.

I've also created interfaces that allow you to implement formatters to produce HTML output rather than a simple character string output.
