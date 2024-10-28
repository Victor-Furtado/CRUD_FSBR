
# CRUD_FSBR

Uma aplicação web em C# capaz de cadastrar, listar, editar e excluir um processo.


## Incializando Banco de dados

- 1. Inicie um banco de dados MicrosoftSQLServer local ou remotamente e escreva a string de conexão no campo `ProcessosDBConnection` do arquivo `appsettings.json`.

 - 2. Execute o comando `UPDATE-DATABASE`

Após esses passos, o banco de dados deve estar conectado a aplicação corretamente.


## Checklist

- [x]  O sistema deverá garantir a integridade das informações cadastradas.
- [x]  A tela onde será feita a listagem dos processos deverá ter paginação.
- [x]  Na listagem dos dados deve-se mostrar apenas o npu, a data de cadastro e a UF do processo.
- [x]  Ao clicar em visualizar, deverá ser exibido as demais informações do processo, sendo possível realizar a confirmação de visualização e salvando a data e hora em que essa confirmação foi realizada.
- [x]  Na tela te cadastro ao selecionar a UF o sistema deverá realizar uma busca na API do IBGE, onde deverão ser persistidas do banco de dados o nome do município selecionado com o seu respectivo código.


## Apêndice

- [API do IBGE](https://servicodados.ibge.gov.br/api/docs/localidades)