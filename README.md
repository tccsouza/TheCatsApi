# Projeto TheCatsApi
TheCatsApi é um projeto do tipo web API criada para integrar com uma base de dados noSQL(MongoDB), podendo buscar gatos armanzenados, com centralização dos logs no ELASTICSEARCH.

## Recursos Utilizados:
- Visual Studio Community 2022
- MongoDB Community 5.0.8
- MongoDB Compass
- Docker(Somente para o ElasticSearch e Kibana)


## Visão Geral

| API | Descrição | Corpo da solicitação | Corpo da resposta |
| ------ | ------ | ------ | ------ |
| GET /api/Cats | Buscar todos os itens de gatos | Nenhum | Matriz de itens de Gatos |
| GET /api/Cats/BucarNome/{name}  | Obter um item por raça | Nenhum | Item de gatos |
| GET /api/Cats/BucarOrigin/{origin} | Obter todos os itens de gatos de uma mesma origem | Nenhum | Matriz de itens de Gatos |
| GET /api/Cats/BuscarTemperament/{temperament}| Obter todos os itens de gatos com um determinado temperamento | Nenhum | Matriz de itens de Gatos |

## Response body
```json
 {
    "id": "627afc49f50a1d4dde9200e4",
    "name": "American Bobtail",
    "origin": "United States",
    "temperament": "Intelligent, Interactive, Lively, Playful, Sensitive",
    "description": "Teste",
    "image": "https://cdn2.thecatapi.com/images/d55E_KMKZ.jpg https://cdn2.thecatapi.com/images/gVrhv_yAY.jpg https://cdn2.thecatapi.com/images/r_njVlaSz.jpg "
  }
```

## Arquitetura
![alt text](https://raw.githubusercontent.com/tccsouza/TheCatsApi/master/Untitled%20Diagram.drawio.png)
## Subindo ambiente
#### MongoDB
Vamos inicializar manualmente o serviço da base de dados, para isso vamos criar uma pasta chamada `db_MongoDB` na raiz do drive C:.
Em seguida abra um prompt de comando no seu Windows e posicione-se na pasta onde o MongoDB foi instalado `(C:\Program Files\MongoDB\Server\5.0\bin)` e digite o seguinte comando para iniciar o serviço  manualmente:
```sh
mongod.exe --dbpath c:\db_MongoDB.
```
#### ElasticSearch/Kibana
Colocar o arquivo docker-compose.yml em uma pasta, e executar o seguinte comando
```sh
docker-compose up -d
```
Eles estaram disponíveis nos seguintes endereços:
- localhost:9200 (ElasticSearch)
- localhost:5601 (Kibana)

#### Nuget packages
Seguintes pacotes foram utilizados na api:

- MongoDB.Driver Version="2.15.1"
-    Serilog.AspNetCore Version="5.0.0"
 -   Serilog.Enrichers.Environment Version="2.2.0"
 -   Serilog.Exceptions Version="8.1.0"
  -  Serilog.Sinks.Debug Version="2.0.0" 
   - Serilog.Sinks.Elasticsearch Version="8.4.1" 
   - Swashbuckle.AspNetCore Version="6.2.3"

### Logs API
![alt text](https://raw.githubusercontent.com/tccsouza/TheCatsApi/master/logKibana.png)

![alt text](https://raw.githubusercontent.com/tccsouza/TheCatsApi/master/logconsole.png)
