# DemoScroll

Minimal Avalonia desktop application to demonstrate unusal scrolling behavior.

This app

- Constructs a window with an ItemsController and fills is with sample text.
- Starts a 2 second timer and inserts sample text to the front of the bound list.

What this demonstrates

- Text will start disappearing the moment new text is added by the timer.
- Grab the scrollbar thumb and move back and forth. Application will stop drawing and other behave erratically.

Test on Windows 10