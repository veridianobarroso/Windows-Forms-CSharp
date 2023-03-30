#Curso de Programação em C#
## Arquivos da aula sobre Windows Forms utilizando C# e aplicações utilizando consulta ao banco de dados

Módulo integrante do Curso de Engenharia de Software em parceria entre Ufac e Compal

Período: 15 a 27 de março de 2023

Laboratório de Estatística, Campus Ufac, Rio Branco/AC

## Banco de dados

Mysql Connector C# -> https://dev.mysql.com/downloads/connector/net/8.0.html
Mysql Server 8.0.32 -> https://dev.mysql.com/downloads/file/?id=516926

CREATE TABLE `pessoa` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Profissao` varchar(100) DEFAULT NULL,
  `Endereco` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
)

INSERT INTO `pessoa` VALUES
(1,'Nome 1','Mecanico','Rua dos Engenheiros'),
(2,'Nome 2','Padeiro','Rua dos Pera'),
(3,'Nome 3','Servidor','Rua dos Morango'),
(4,'Nome 4','Comerciante','Rua das Uvas'),
(5,'Nome 5','Advogado','Rua dos Laranja'),
(6,'Nome 6','Medico','Rua dos Abacate'),
(7,'Nome 7','Vendedor','Rua dos Banana'),
(8,'Nome 8','Auxiliar','Rua dos Limao'),
(9,'Nome 9','Diretor','Rua dos Abacaxi');
