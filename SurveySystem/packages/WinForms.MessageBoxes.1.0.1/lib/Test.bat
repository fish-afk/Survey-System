REM Show an info message for 10 seconds
MessageBoxSender.exe -m "Hello World!" -t "Title" -i -timeout 10000

REM Show an error message for 3 seconds
MessageBoxSender.exe -m "Bye-bye World!" -t "Title" -e -timeout 3000

REM Show a question message for 8 seconds with default choice NO
MessageBoxSender.exe -m "World can you forgive?" -t "Title" -q -timeout 8000 -n