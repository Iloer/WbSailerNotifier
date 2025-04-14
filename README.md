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

```bash
docker run -d --restart unless-stopped --name wb-sailer-notifier -e DataBaseConfiguration__DbConnection="Host=192.168.31.247:5432;Database=wb-sailer-notifier" -e DataBaseConfiguration__DbUserName="postgres" -e DataBaseConfiguration__DbPassword="postgres" -e WbConfiguration__StatisticBaseUrl="https://statistics-api.wildberries.ru" -e WbConfiguration__Token="{WBTOKEN}" -e TelegramConfiguration__BaseUrl="https://api.telegram.org/" -e TelegramConfiguration__Token="{TGTOKEN}" -e TelegramConfiguration__ChatId="-4513998224" wb-sailer-notifier:latest
```

