
# MS Teams AutoLaunch

This is a small tool which reads a `.csv` file
containing times and URLs for MS Teams meetings.

It then waits until 2 minutes before the next time listed
and opens MS teams to the given meeting URL.


# Design Plans

 - Allow users to pass a command-line argument to the CSV file,
   defaulting to `C:/Users/UserName/Documents/teams.csv`.
 - Use an interface to read times + urls; this will
   allow us to replace the `.csv` file with a query to Outlook OWA later

# Building

```bash
dotnet publish -c release
```

# Running

```bash
./bin/release/netcoreapp3.1/publish/msteams-autolaunch-tool
# or
.\bin\release\netcoreapp3.1\publish\msteams-autolaunch-tool.exe
```

