# docSpiderBackend
-> Aqui está um projeto de uma api back-end para fornecer dados de arquivos PDfs parao front-end
-> Há um modelo do banco de dados utilizado na pasta raiz do projeto chamado 'backupDocSpiderServer.json'. Esse arquivo deve ser importado, por exemplo, pelo 'pgAdmin' que é um 'gerenciador' de banco de dados postgreSQL. Ao importar, terá um modelo da tabela utilizada para montar a api, além do esquema. Porém, caso queira montar essa tabela manualmente, seguem os dados (esses dados podem ser encontrados no arquivo 'appsettings.json' da solução do projeto na string de conexão (ConnectionStrings) denominada de 'docSpiderAppCon'):

database: docspider
usuário: postgres 
senha: 1234
porta: 5432
server: localhost

Tabela:
create table Pdf(
	id serial,
	title varchar(500),
	description varchar(500) unique,
	name_file varchar(500),
	p_file serial, 
	created_at TIMESTAMP NOT NULL DEFAULT NOW()
);

Dados a serem inseridos como exemplos:
-> insert into Pdf(title,description,name_file,created_at) values ('teste', 'Descricao para teste','Arquivo de teste', current_timestamp)
-> insert into Pdf(title,description,name_file,created_at) values ('Tecnologias de documentos', 'Aqui seus documentos sao melhores','tecnologias utilizadas', current_timestamp)

API para acessar o endereço os dados de retorno para o front-end:
->https://localhost:44391/api/pdf/ 

