
# CRUD_FSBR

Uma aplica��o web em C# capaz de cadastrar, listar, editar e excluir um processo.


## Incializando Banco de dados

- 1. Inicie um banco de dados MicrosoftSQLServer local ou remotamente e escreva a string de conex�o no campo `ProcessosDBConnection` do arquivo `appsettings.json`.

 - 2. Execute o comando `UPDATE-DATABASE`

Ap�s esses passos, o banco de dados deve estar conectado a aplica��o corretamente.


## Checklist

- [x]  O sistema dever� garantir a integridade das informa��es cadastradas.
- [x]  A tela onde ser� feita a listagem dos processos dever� ter pagina��o.
- [x]  Na listagem dos dados deve-se mostrar apenas o npu, a data de cadastro e a UF do processo.
- [x]  Ao clicar em visualizar, dever� ser exibido as demais informa��es do processo, sendo poss�vel realizar a confirma��o de visualiza��o e salvando a data e hora em que essa confirma��o foi realizada.
- [x]  Na tela te cadastro ao selecionar a UF o sistema dever� realizar uma busca na API do IBGE, onde dever�o ser persistidas do banco de dados o nome do munic�pio selecionado com o seu respectivo c�digo.


## Ap�ndice

- [API do IBGE](https://servicodados.ibge.gov.br/api/docs/localidades)