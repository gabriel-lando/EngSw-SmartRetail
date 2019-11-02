Trabalho Final Engenharia de Software N 2019/1
-------------------------

#### Objetivo:
O trabalho é dividido em duas principais partes:
- **PRODUCT OWNER:** Propor uma ideia inovadora de produto de software, apresentando uma visão do produto e suas features, que devem satisfazer as restrições apresentadas e diretrizes descritas na descrição da Parte 1.
- **DEVELOPER:** O grupo recebeu a especificação de um produto de software (Etapa 1) que outro grupo especificou e deverá desenvolver um sistema de software que implemente as funcionalidades especificadas na forma de um simulador. **Obs:** a especificação do trabalho encontra-se em [Docs/Definicao - Grupo 3 - Etapa 1.pdf](/Docs/Definicao%20-%20Grupo%203%20-%20Etapa%201.pdf).

#### Como usar:
##### Instalar o SQL Server (Banco de Dados):
1. É necessário ter o [Microsoft SQL Server 2017 Express Edition](https://www.microsoft.com/pt-br/sql-server/sql-server-editions-express) instalado em sua máquina. Recomendo serguir o tutorial através [desse link](https://www.mssqltips.com/sqlservertip/5612/getting-started-with-sql-server-2017-express-localdb/) para instalá-lo (OBS: Seguir somente a primeira parte, antes de "Step 2: Patch SQL Server 2017").
2. Após instalar o DB, abrir um Prompt de Comandos (ou Windows Power Shell) e executar os seguintes comandos:
```
SqlLocalDb create "SmartRetail"
SqlLocalDb start "SmartRetail"
sqlcmd -S "(localdb)\SmartRetail"
```
3. Se tudo der certo, irá aparecer uma linha com a escrita ```1> ``` ao final, os seguintes comandos devem ser executados:
```
USE [master]
GO
ALTER LOGIN [sa] WITH PASSWORD=N'admin'
GO
ALTER LOGIN [sa] ENABLE
GO
```
4. Após isso, pressionar Ctrl+C para encerrar esse comando.

##### Criar tabelas no DB e executar o programa:
1. Com o [Visual Studio 2019 Enterprise](https://visualstudio.microsoft.com/pt-br/vs/) aberto, clonar o repositório do programa.
2. Primeiro, é necessário criar as tabelas no DB, para isso, deve-se escolher as opções de compilação **Release, Any CPU e CreateTablesDB** e Iniciar. Uma tela de comandos irá aparecer confirmando se as ações foram concluídas com sucesso.
3. Após a criação das tabelas no DB, deve-se mudar as opções de compilação para  **Release, Any CPU e SmartRetail**. Executando, deve aparecer 4 telas, chamadas ```Caixa```, ```Totem```, ```Prateleira``` e ```App```.
	- Obs: Para próximas execuções, pode-se abrir diretamente o arquivo gerado ```SmartRetail.exe``` que encontra-se em ```SmartRetail\bin\Release\app.publish\``` na pasta onde os arquivos do GitHub foram clonados (default: ```C:\Users\SEU_USUARIO\source\repos\EngSw-SmartRetail\```)

##### Utilizando o App:
1. Primeiramente, é necessário fazer login no **App** como gerente, utilizando as seguintes credenciais:
	- **Email:** admin@admin.com
	- **Password:** admin
2. Como gerente, é possível cadastrar e remover fornecedores, gerentes e ofertas, listar produtos, consultar dados, etc.
3. Na aba "Cadastrar", cadastre ao menos um "Fornecedor" e alguns produtos.
	- Também é possível fazer login como fornecedor, após cadastrá-lo. Na tela de fornecedor é possível ver se algum produtor fornecido por esse fornecedor está fora de estoque, alterar o estoque dos produtos existentes e cadastrar novos. Para remover um produto existente, é necessário apenas deixar um dos seus campos em branco.
4. Para fazer logoff, basta acessar a "Home" e pressionar o botão no canto superior direito da tela.

##### Utilizando as demais telas:
1. Primeiramente, deve-se arrastar uma imagem (alguns exemplos em [Docs/Clients](/Docs/Clients/)) e soltá-la sobre a tela denominada "Caixa", isso representa um novo usuário chegando na loja. Como o sistema irá detectar que é um novo cliente, será necessário preencher os dados desse usuário e confirmar o cadastro.
2. Arrastando essa mesma imagem para a interface "Prateleira" surgirão os produtos disponíveis na loja. Primeiramente, deve selecionar uma das prateleira, os produtos dela serão listados no ComboBox abaixo dela. Ao selecionar um produto, uma quantidade será exibida (inicialmente, zero). Para confirmar, aperte no botão "Atualizar". Clique em "Cancelar" ou sobre a imagem do cliente no canto esquerdo para voltar para a tela de espera.
	- Obs: Para remover um produto do carrinho, basta selecionar a quantidade 0 para esse ítem e atualizar.
3. Arrastando a mesma imagem para a tela "Totem", aparecerá as ofertas recomendadas para esse cliente. Do lado direito aparecerá o carrinho com os ítens adicionados. Clicando na foto no canto superior esquerdo, o Totem voltará para a tela de espera.
	- Obs: Para que alguma oferta seja exibida, é necessário cadastrá-la no App, na aba "Ofertas", utilizando-se algum usuário de gerente.
4. Arrastando novamente a imagem para tela "Caixa", a compra será finalizada (isso representa o cliente saindo da loja). Nessa tela, aparecerá um resumo da compra (carrinho e valor total).
	- Se o mesmo cliente voltar a loja (uma imagem de mesmo nome for arrastada pra tela "Caixa"), um novo cadastro não será necessário de ser realizado, pois o mesmo fica armazenado no DB.


#### Programação:
- Linguagem utilizada: C#
- IDE: [Visual Studio 2019 Enterprise](https://visualstudio.microsoft.com/pt-br/vs/)
- DB: [Microsoft SQL Server 2017 Express Edition](https://www.microsoft.com/pt-br/sql-server/sql-server-editions-express)
- Interface gráfica: Windows Forms

#### Disciplina:
- Engenharia de Software N (INF01127) - INF-UFRGS

#### Professor:
- [Ingrid Oliveira de Nunes](http://www.inf.ufrgs.br/~ingridnunes/)

#### Grupo:

- [Eduardo Spitzer Fischer](https://github.com/eduardofischer/)
- [Gabriel Lando](https://github.com/gabriel-lando/)
- [Rodrigo Paranhos Bastos](https://github.com/ropbastos/)
