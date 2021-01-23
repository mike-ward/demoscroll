**DemoScroll** is a minimal Avalonia desktop application that demonstrates undesirable scrolling behavior.

What it does:

- Constructs a window that contains an `ItemsRepeater`
- Fills a list with sample text that is bound to the `ItemsRepeater`.
- Starts a 2 second timer and inserts sample text to the front of the list.

What it demonstrates:

- Text will start disappearing the moment new text is added by the timer.
- Grab the scrollbar thumb and move up and down. Application will stop drawing and otherwise behave erratically.

**Desktop (please complete the following information):**
 - OS: Microsoft Windows [Version 10.0.19042.746]
 - Version 0.10
