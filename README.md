# UrlParser
Parse a URL string and display in a readable format.

If the URL contains hex strings such as %20 (space), it will be converted to a space character.  If the character is a ? or &, line breaks are added for clarity.

The result shows parameter key/value pairs

For example, if the URL is:

https://www.youtube.com/redirect?event=video_description&redir_token=QUFFLUhqbDhLTnhNNEhvbEZUQ05kTUtmeEZKSkNxYTRrZ3xBQ3Jtc0ttaW14NjNoYUUycFVMNW1jRGRoWUVlcjluY3U0M2xxbFE1OGU5NTJBR2llYXlLVzZ6anpidmlkRzhoeUd5Wm9DdU4xZHhFWGhQTHd6MUQ4SFhMV0k1U3ZiNk1UR3VYdWg4YVRxdlc1R3pBQjBHdXd1WQ&q=https%3A%2F%2FIAmTimCorey.com%2F&v=PFNYV3ZvJOw

The result will be:

https://www.youtube.com/redirect 

?

event=video_description 

& 

redir_token=QUFFLUhqbDhLTnhNNEhvbEZUQ05kTUtmeEZKSkNxYTRrZ3xBQ3Jtc0ttaW14NjNoYUUycFVMNW1jRGRoWUVlcjluY3U0M2xxbFE1OGU5NTJBR2llYXlLVzZ6anpidmlkRzhoeUd5Wm9DdU4xZHhFWGhQTHd6MUQ4SFhMV0k1U3ZiNk1UR3VYdWg4YVRxdlc1R3pBQjBHdXd1WQ 

& 

q=https://IAmTimCorey.com/ 

& 

v=PFNYV3ZvJOw 
