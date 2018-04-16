CREATE DATABASE [Testes]
GO


USE [Testes]
GO


CREATE TABLE [dbo].[Produtos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](150) NULL,
	[Preco] [decimal](18, 2) NULL
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Users](
	[UserID] [varchar](20) NOT NULL,
	[AccessKey] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

insert into Users(UserId,Accesskey) values ('admin','MTIzNA==') 
insert into Users(UserId,Accesskey) values ('usuario','MTIzNA==')

insert into Produtos(Descricao,preco) values ('Java vol 1',120.58) 
insert into Produtos(Descricao,preco) values ('C# vol2',150) 
insert into Produtos(Descricao,preco) values ('LDAP For C#',1500.63) 
