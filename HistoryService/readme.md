Build the app
```
dotnet build
```

Run the app
```
dotnet run
```


Build the container
```
docker build -t historyws .
```

Run the container
```
# with console
docker run -it --rm -p 8080:80 --name historyws historyws

# without console
docker run --rm --detach -p 8085:80 --name historyws5 historyws
```

Call Webservice method
http://localhost:8080/ui/histories/events

Save container to file
```
docker save historyws -o historyws.tar
```