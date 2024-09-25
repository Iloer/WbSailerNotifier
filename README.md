# WbSailerNotifier

Build
```
docker build -t wb-sailer-notifier .
```

Run
```
docker run -d
    --restart unless-stopped
    --name wb-sailer-notifier
    --dns 172.17.0.1
    -e DataBaseConfiguration__DbConnection=$DbConnection_dev
    -e DataBaseConfiguration__DbUserName=$DbUserName_dev
    -e DataBaseConfiguration__DbPassword=$DbPassword_dev
    -e WbConfiguration__StatisticBaseUrl=$StatisticBaseUrl
    -e WbConfiguration__Token=$WbToken
    -e TelegramConfiguration__BaseUrl=$BaseUrl
    -e TelegramConfiguration__Token=$Token
    -e TelegramConfiguration__ChatId=$ChatId
    wb-sailer-notifier:latest
```