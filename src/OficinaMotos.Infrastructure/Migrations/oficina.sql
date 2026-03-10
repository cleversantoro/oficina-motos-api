-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.44 - MySQL Community Server - GPL
-- OS do Servidor:               Linux
-- HeidiSQL Versão:              12.15.0.7171
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Copiando estrutura para tabela oficina_db.cad_clientes
CREATE TABLE IF NOT EXISTS `cad_clientes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Codigo` bigint NOT NULL,
  `Nome` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `NomeExibicao` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Documento` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Tipo` int NOT NULL,
  `Status` int NOT NULL COMMENT '0 = Inativo\r\n1 = Ativo\r\n2 = Suspenso\r\n3 = Bloqueado',
  `Vip` tinyint(1) NOT NULL DEFAULT '0',
  `Observacoes` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `OrigemCadastroId` int NOT NULL DEFAULT '0',
  `Telefone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Email` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Origem_Id` bigint DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_origem` (`Origem_Id`),
  CONSTRAINT `FK_cad_clientes_origem` FOREIGN KEY (`Origem_Id`) REFERENCES `cad_clientes_origens` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_anexos
CREATE TABLE IF NOT EXISTS `cad_clientes_anexos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Nome` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Tipo` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Url` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Observacao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_anexos_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_anexos_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_contatos
CREATE TABLE IF NOT EXISTS `cad_clientes_contatos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Tipo` int NOT NULL,
  `Valor` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Observacao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_contatos_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_contatos_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_documentos
CREATE TABLE IF NOT EXISTS `cad_clientes_documentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Tipo` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Documento` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Data_Emissao` date DEFAULT NULL,
  `Data_Validade` date DEFAULT NULL,
  `Orgao_Expedidor` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_documentos_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_documentos_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11031 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_enderecos
CREATE TABLE IF NOT EXISTS `cad_clientes_enderecos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Tipo` int NOT NULL,
  `Cep` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Logradouro` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Numero` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Bairro` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cidade` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Estado` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Pais` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Complemento` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_enderecos_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_enderecos_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_financeiro
CREATE TABLE IF NOT EXISTS `cad_clientes_financeiro` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Limite_Credito` decimal(10,2) DEFAULT NULL,
  `Prazo_Pagamento` int DEFAULT NULL,
  `Bloqueado` tinyint(1) NOT NULL DEFAULT '0',
  `Observacoes` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_financeiro_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_financeiro_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_indicacoes
CREATE TABLE IF NOT EXISTS `cad_clientes_indicacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Indicador_Nome` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Indicador_Telefone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Observacao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_indicacoes_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_indicacoes_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_lgpd_consentimentos
CREATE TABLE IF NOT EXISTS `cad_clientes_lgpd_consentimentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Tipo` int NOT NULL,
  `Aceito` tinyint(1) NOT NULL,
  `Data` datetime(6) DEFAULT NULL,
  `Valido_Ate` datetime(6) DEFAULT NULL,
  `Observacoes` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Canal` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_lgpd_consentimentos_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_lgpd_consentimentos_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_origens
CREATE TABLE IF NOT EXISTS `cad_clientes_origens` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Nome` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Descricao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_pf
CREATE TABLE IF NOT EXISTS `cad_clientes_pf` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Cpf` varchar(14) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Rg` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Data_Nascimento` date DEFAULT NULL,
  `Genero` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Estado_Civil` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Profissao` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_pf_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_pf_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_clientes_pj
CREATE TABLE IF NOT EXISTS `cad_clientes_pj` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Cnpj` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Razao_Social` varchar(180) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Nome_Fantasia` varchar(180) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Inscricao_Estadual` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Inscricao_Municipal` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Responsavel` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_clientes_pj_cliente` (`Cliente_Id`),
  CONSTRAINT `FK_cad_clientes_pj_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores
CREATE TABLE IF NOT EXISTS `cad_fornecedores` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Tipo` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Razao_Social` varchar(160) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Nome_Fantasia` varchar(160) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Documento` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Inscricao_Estadual` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Inscricao_Municipal` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Segmento_Principal_Id` bigint DEFAULT NULL,
  `Website` varchar(160) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Email` varchar(160) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Telefone_Principal` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Status` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'ATIVO',
  `Condicao_Pagamento_Padrao` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Prazo_Entrega_Medio` int DEFAULT NULL,
  `Nota_Media` decimal(4,2) DEFAULT NULL,
  `Observacoes` varchar(600) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Prazo_Garantia_Padrao` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Termos_Negociados` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Atendimento_Personalizado` tinyint(1) NOT NULL DEFAULT '0',
  `Retirada_Local` tinyint(1) NOT NULL DEFAULT '0',
  `Rating_Logistica` decimal(4,2) DEFAULT NULL,
  `Rating_Qualidade` decimal(4,2) DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_codigo` (`Codigo`),
  UNIQUE KEY `UX_cad_fornecedores_documento` (`Documento`),
  KEY `IX_cad_fornecedores_segmento` (`Segmento_Principal_Id`),
  CONSTRAINT `FK_cad_fornecedores_segmento` FOREIGN KEY (`Segmento_Principal_Id`) REFERENCES `cad_fornecedores_segmentos` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_avaliacoes
CREATE TABLE IF NOT EXISTS `cad_fornecedores_avaliacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Data_Avaliacao` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Avaliado_Por` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Categoria` varchar(60) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Nota` decimal(4,2) NOT NULL,
  `Comentarios` varchar(400) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_fornecedores_avaliacoes_fornecedor` (`Fornecedor_Id`,`Data_Avaliacao`),
  CONSTRAINT `FK_cad_fornecedores_avaliacoes_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_bancos
CREATE TABLE IF NOT EXISTS `cad_fornecedores_bancos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Banco` varchar(80) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Agencia` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Conta` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Digito` varchar(5) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Tipo_Conta` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Pix_Chave` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Observacoes` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_bancos` (`Fornecedor_Id`,`Banco`,`Agencia`,`Conta`,`Digito`),
  CONSTRAINT `FK_cad_fornecedores_bancos_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_certificacoes
CREATE TABLE IF NOT EXISTS `cad_fornecedores_certificacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Titulo` varchar(160) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Instituicao` varchar(160) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Data_Emissao` date DEFAULT NULL,
  `Data_Validade` date DEFAULT NULL,
  `Codigo_Certificacao` varchar(60) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Escopo` varchar(200) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_certificacoes` (`Fornecedor_Id`,`Titulo`),
  CONSTRAINT `FK_cad_fornecedores_certificacoes_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_contatos
CREATE TABLE IF NOT EXISTS `cad_fornecedores_contatos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Tipo` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Valor` varchar(160) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Observacao` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_contatos` (`Fornecedor_Id`,`Tipo`,`Valor`),
  CONSTRAINT `FK_cad_fornecedores_contatos_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_documentos
CREATE TABLE IF NOT EXISTS `cad_fornecedores_documentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Tipo` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Numero` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Data_Emissao` date DEFAULT NULL,
  `Data_Validade` date DEFAULT NULL,
  `Orgao_Expedidor` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Arquivo_Url` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Observacoes` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_documentos` (`Fornecedor_Id`,`Tipo`,`Numero`),
  CONSTRAINT `FK_cad_fornecedores_documentos_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_enderecos
CREATE TABLE IF NOT EXISTS `cad_fornecedores_enderecos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Tipo` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cep` varchar(12) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Logradouro` varchar(160) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Numero` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Bairro` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cidade` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Estado` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Pais` varchar(80) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Complemento` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Observacao` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_fornecedores_enderecos_fornecedor_tipo` (`Fornecedor_Id`,`Tipo`),
  CONSTRAINT `FK_cad_fornecedores_enderecos_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_representantes
CREATE TABLE IF NOT EXISTS `cad_fornecedores_representantes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Nome` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cargo` varchar(120) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Email` varchar(160) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Telefone` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Celular` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Preferencia_Contato` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Observacoes` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_representantes` (`Fornecedor_Id`,`Nome`),
  CONSTRAINT `FK_cad_fornecedores_representantes_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_segmentos
CREATE TABLE IF NOT EXISTS `cad_fornecedores_segmentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Nome` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Descricao` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_segmentos_codigo` (`Codigo`),
  UNIQUE KEY `UX_cad_fornecedores_segmentos_nome` (`Nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_fornecedores_segmentos_rel
CREATE TABLE IF NOT EXISTS `cad_fornecedores_segmentos_rel` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Fornecedor_Id` bigint NOT NULL,
  `Segmento_Id` bigint NOT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Observacoes` varchar(240) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_fornecedores_segmentos_rel` (`Fornecedor_Id`,`Segmento_Id`),
  KEY `IX_cad_fornecedores_segmentos_rel_segmento` (`Segmento_Id`),
  CONSTRAINT `FK_cad_fornecedores_segmentos_rel_fornecedor` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_cad_fornecedores_segmentos_rel_segmento` FOREIGN KEY (`Segmento_Id`) REFERENCES `cad_fornecedores_segmentos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos
CREATE TABLE IF NOT EXISTS `cad_mecanicos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Nome` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Sobrenome` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Nome_Social` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Documento_Principal` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Tipo_Documento` int NOT NULL DEFAULT '1',
  `Data_Nascimento` date DEFAULT NULL,
  `Data_Admissao` date NOT NULL,
  `Data_Demissao` date DEFAULT NULL,
  `Status` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Ativo',
  `Especialidade_Principal_Id` bigint DEFAULT NULL,
  `Nivel` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Pleno',
  `Valor_Hora` decimal(10,2) NOT NULL DEFAULT '0.00',
  `Carga_Horaria_Semanal` int NOT NULL DEFAULT '44',
  `Observacoes` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_mecanicos_codigo` (`Codigo`),
  KEY `IX_cad_mecanicos_especialidade` (`Especialidade_Principal_Id`),
  CONSTRAINT `FK_cad_mecanicos_especialidade` FOREIGN KEY (`Especialidade_Principal_Id`) REFERENCES `cad_mecanicos_especialidades` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_certificacoes
CREATE TABLE IF NOT EXISTS `cad_mecanicos_certificacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Especialidade_Id` bigint DEFAULT NULL,
  `Titulo` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Instituicao` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Data_Conclusao` date DEFAULT NULL,
  `Data_Validade` date DEFAULT NULL,
  `Codigo_Certificacao` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_mecanicos_certificacoes_mecanico` (`Mecanico_Id`),
  KEY `IX_cad_mecanicos_certificacoes_especialidade` (`Especialidade_Id`),
  CONSTRAINT `FK_cad_mecanicos_certificacoes_especialidade` FOREIGN KEY (`Especialidade_Id`) REFERENCES `cad_mecanicos_especialidades` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_cad_mecanicos_certificacoes_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_contatos
CREATE TABLE IF NOT EXISTS `cad_mecanicos_contatos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Tipo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Valor` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Observacao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_mecanicos_contatos_mecanico` (`Mecanico_Id`),
  CONSTRAINT `FK_cad_mecanicos_contatos_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_disponibilidades
CREATE TABLE IF NOT EXISTS `cad_mecanicos_disponibilidades` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Dia_Semana` tinyint NOT NULL,
  `Hora_Inicio` time NOT NULL,
  `Hora_Fim` time NOT NULL,
  `Capacidade_Atendimentos` int NOT NULL DEFAULT '5',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_mecanicos_disponibilidades_mecanico` (`Mecanico_Id`),
  CONSTRAINT `FK_cad_mecanicos_disponibilidades_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_documentos
CREATE TABLE IF NOT EXISTS `cad_mecanicos_documentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Tipo` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Numero` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Data_Emissao` date DEFAULT NULL,
  `Data_Validade` date DEFAULT NULL,
  `Orgao_Expedidor` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Arquivo_Url` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_mecanicos_documentos_mecanico` (`Mecanico_Id`),
  CONSTRAINT `FK_cad_mecanicos_documentos_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_enderecos
CREATE TABLE IF NOT EXISTS `cad_mecanicos_enderecos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Tipo` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cep` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Logradouro` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Numero` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Bairro` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cidade` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Estado` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Pais` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Complemento` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_mecanicos_enderecos_mecanico` (`Mecanico_Id`),
  CONSTRAINT `FK_cad_mecanicos_enderecos_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_especialidades
CREATE TABLE IF NOT EXISTS `cad_mecanicos_especialidades` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Nome` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Descricao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_mecanicos_especialidades_codigo` (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_especialidades_rel
CREATE TABLE IF NOT EXISTS `cad_mecanicos_especialidades_rel` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Especialidade_Id` bigint NOT NULL,
  `Nivel` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Pleno',
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Anotacoes` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_mecanicos_especialidades_rel` (`Mecanico_Id`,`Especialidade_Id`),
  KEY `IX_cad_mecanicos_especialidades_rel_especialidade` (`Especialidade_Id`),
  CONSTRAINT `FK_cad_mecanicos_especialidades_rel_especialidade` FOREIGN KEY (`Especialidade_Id`) REFERENCES `cad_mecanicos_especialidades` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_cad_mecanicos_especialidades_rel_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_mecanicos_experiencias
CREATE TABLE IF NOT EXISTS `cad_mecanicos_experiencias` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Mecanico_Id` bigint NOT NULL,
  `Empresa` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Cargo` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Data_Inicio` date DEFAULT NULL,
  `Data_Fim` date DEFAULT NULL,
  `Resumo_Atividades` varchar(400) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_mecanicos_experiencias_mecanico` (`Mecanico_Id`),
  CONSTRAINT `FK_cad_mecanicos_experiencias_mecanico` FOREIGN KEY (`Mecanico_Id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_veiculos
CREATE TABLE IF NOT EXISTS `cad_veiculos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Cliente_Id` bigint NOT NULL,
  `Placa` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Modelo_Id` bigint DEFAULT NULL,
  `Ano_Fab` int DEFAULT NULL,
  `Ano_Mod` int DEFAULT NULL,
  `Cor` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Chassi` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Renavam` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `KM` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Combustivel` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Observacao` varchar(240) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Principal` tinyint(1) NOT NULL DEFAULT '0',
  `Ativo` tinyint(1) NOT NULL DEFAULT '1',
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_veiculos_placa` (`Placa`),
  KEY `IX_cad_veiculos_cliente` (`Cliente_Id`),
  KEY `IX_cad_veiculos_modelo` (`Modelo_Id`),
  CONSTRAINT `FK_cad_veiculos_cliente` FOREIGN KEY (`Cliente_Id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_cad_veiculos_modelo` FOREIGN KEY (`Modelo_Id`) REFERENCES `cad_veiculos_modelos` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_veiculos_marcas
CREATE TABLE IF NOT EXISTS `cad_veiculos_marcas` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Nome` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Pais` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_cad_veiculos_marcas_nome` (`Nome`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.cad_veiculos_modelos
CREATE TABLE IF NOT EXISTS `cad_veiculos_modelos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `Marca_Id` bigint NOT NULL,
  `Nome` varchar(160) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Ano_Inicio` int DEFAULT NULL,
  `Ano_Fim` int DEFAULT NULL,
  `Created_At` datetime(6) NOT NULL DEFAULT CURRENT_TIMESTAMP(6),
  `Updated_At` datetime(6) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(6),
  PRIMARY KEY (`Id`),
  KEY `IX_cad_veiculos_modelos_marca` (`Marca_Id`),
  CONSTRAINT `FK_cad_veiculos_modelos_marca` FOREIGN KEY (`Marca_Id`) REFERENCES `cad_veiculos_marcas` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_categorias
CREATE TABLE IF NOT EXISTS `est_categorias` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `descricao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_est_categorias_nome` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_fabricantes
CREATE TABLE IF NOT EXISTS `est_fabricantes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `nome` varchar(120) NOT NULL,
  `cnpj` varchar(20) DEFAULT NULL,
  `contato` varchar(100) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_est_fabricantes_nome` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_localizacoes
CREATE TABLE IF NOT EXISTS `est_localizacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) NOT NULL,
  `corredor` varchar(20) DEFAULT NULL,
  `prateleira` varchar(20) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_est_localizacoes_descricao` (`descricao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_movimentacoes
CREATE TABLE IF NOT EXISTS `est_movimentacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `peca_id` bigint NOT NULL,
  `quantidade` int NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `referencia` varchar(100) DEFAULT NULL,
  `data_movimentacao` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuario` varchar(100) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_est_movimentacoes_peca` (`peca_id`),
  CONSTRAINT `FK_est_movimentacoes_peca` FOREIGN KEY (`peca_id`) REFERENCES `est_pecas` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_pecas
CREATE TABLE IF NOT EXISTS `est_pecas` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `codigo` varchar(50) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `fabricante_id` bigint DEFAULT NULL,
  `categoria_id` bigint DEFAULT NULL,
  `localizacao_id` bigint DEFAULT NULL,
  `preco_unitario` decimal(12,2) NOT NULL,
  `quantidade` int NOT NULL DEFAULT '0',
  `estoque_minimo` int DEFAULT '0',
  `estoque_maximo` int DEFAULT '0',
  `unidade` varchar(10) DEFAULT 'UN',
  `status` varchar(20) DEFAULT 'Ativo',
  `observacoes` text,
  `data_cadastro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_est_pecas_codigo` (`codigo`),
  KEY `IX_est_pecas_fabricante` (`fabricante_id`),
  KEY `IX_est_pecas_categoria` (`categoria_id`),
  KEY `IX_est_pecas_localizacao` (`localizacao_id`),
  CONSTRAINT `FK_est_pecas_categoria` FOREIGN KEY (`categoria_id`) REFERENCES `est_categorias` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_est_pecas_fabricante` FOREIGN KEY (`fabricante_id`) REFERENCES `est_fabricantes` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_est_pecas_localizacao` FOREIGN KEY (`localizacao_id`) REFERENCES `est_localizacoes` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_pecas_anexos
CREATE TABLE IF NOT EXISTS `est_pecas_anexos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `peca_id` bigint NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `url` varchar(500) DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `data_upload` datetime DEFAULT CURRENT_TIMESTAMP,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_est_pecas_anexos_peca` (`peca_id`),
  CONSTRAINT `FK_est_pecas_anexos_peca` FOREIGN KEY (`peca_id`) REFERENCES `est_pecas` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_pecas_fornecedores
CREATE TABLE IF NOT EXISTS `est_pecas_fornecedores` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `peca_id` bigint NOT NULL,
  `fornecedor_id` bigint NOT NULL,
  `preco` decimal(12,2) DEFAULT NULL,
  `prazo_entrega` int DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_est_pecas_fornecedores` (`peca_id`,`fornecedor_id`),
  KEY `IX_est_pecas_fornecedores_fornecedor` (`fornecedor_id`),
  CONSTRAINT `FK_est_pecas_fornecedores_fornecedor` FOREIGN KEY (`fornecedor_id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_est_pecas_fornecedores_peca` FOREIGN KEY (`peca_id`) REFERENCES `est_pecas` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.est_pecas_historico
CREATE TABLE IF NOT EXISTS `est_pecas_historico` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `peca_id` bigint NOT NULL,
  `data_alteracao` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuario` varchar(100) DEFAULT NULL,
  `campo` varchar(100) DEFAULT NULL,
  `valor_antigo` text,
  `valor_novo` text,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_est_pecas_historico_peca` (`peca_id`),
  CONSTRAINT `FK_est_pecas_historico_peca` FOREIGN KEY (`peca_id`) REFERENCES `est_pecas` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_anexos
CREATE TABLE IF NOT EXISTS `fin_anexos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `pagamento_id` bigint DEFAULT NULL,
  `conta_pagar_id` bigint DEFAULT NULL,
  `conta_receber_id` bigint DEFAULT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `url` varchar(500) DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `data_upload` datetime(3) DEFAULT CURRENT_TIMESTAMP(3),
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_fin_anexos_pagamento` (`pagamento_id`),
  KEY `IX_fin_anexos_conta_pagar` (`conta_pagar_id`),
  KEY `IX_fin_anexos_conta_receber` (`conta_receber_id`),
  CONSTRAINT `FK_fin_anexos_conta_pagar` FOREIGN KEY (`conta_pagar_id`) REFERENCES `fin_contas_pagar` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_fin_anexos_conta_receber` FOREIGN KEY (`conta_receber_id`) REFERENCES `fin_contas_receber` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_fin_anexos_pagamento` FOREIGN KEY (`pagamento_id`) REFERENCES `fin_pagamentos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_contas_pagar
CREATE TABLE IF NOT EXISTS `fin_contas_pagar` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `fornecedor_id` bigint DEFAULT NULL,
  `descricao` varchar(200) NOT NULL,
  `valor` decimal(12,2) NOT NULL,
  `vencimento` datetime(3) NOT NULL,
  `status` varchar(20) NOT NULL,
  `data_pagamento` datetime(3) DEFAULT NULL,
  `metodo_id` bigint DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_fin_contas_pagar_fornecedor` (`fornecedor_id`),
  KEY `IX_fin_contas_pagar_metodo` (`metodo_id`),
  CONSTRAINT `FK_fin_contas_pagar_fornecedor` FOREIGN KEY (`fornecedor_id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_fin_contas_pagar_metodo` FOREIGN KEY (`metodo_id`) REFERENCES `fin_metodos_pagamento` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_contas_receber
CREATE TABLE IF NOT EXISTS `fin_contas_receber` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `cliente_id` bigint DEFAULT NULL,
  `descricao` varchar(200) NOT NULL,
  `valor` decimal(12,2) NOT NULL,
  `vencimento` datetime(3) NOT NULL,
  `status` varchar(20) NOT NULL,
  `data_recebimento` datetime(3) DEFAULT NULL,
  `metodo_id` bigint DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_fin_contas_receber_cliente` (`cliente_id`),
  KEY `IX_fin_contas_receber_metodo` (`metodo_id`),
  CONSTRAINT `FK_fin_contas_receber_cliente` FOREIGN KEY (`cliente_id`) REFERENCES `cad_clientes` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_fin_contas_receber_metodo` FOREIGN KEY (`metodo_id`) REFERENCES `fin_metodos_pagamento` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_historico
CREATE TABLE IF NOT EXISTS `fin_historico` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `entidade` varchar(50) NOT NULL,
  `entidade_id` bigint NOT NULL,
  `data_alteracao` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `usuario` varchar(100) DEFAULT NULL,
  `campo` varchar(100) DEFAULT NULL,
  `valor_antigo` text,
  `valor_novo` text,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_fin_historico_entidade` (`entidade`,`entidade_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_lancamentos
CREATE TABLE IF NOT EXISTS `fin_lancamentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `tipo` varchar(10) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `valor` decimal(12,2) NOT NULL,
  `data_lancamento` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `referencia` varchar(100) DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_metodos_pagamento
CREATE TABLE IF NOT EXISTS `fin_metodos_pagamento` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `descricao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UX_fin_metodos_pagamento_nome` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.fin_pagamentos
CREATE TABLE IF NOT EXISTS `fin_pagamentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint DEFAULT NULL,
  `cliente_id` bigint DEFAULT NULL,
  `fornecedor_id` bigint DEFAULT NULL,
  `valor` decimal(12,2) NOT NULL,
  `status` varchar(20) NOT NULL,
  `data_pagamento` datetime(3) DEFAULT NULL,
  `metodo_id` bigint DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_fin_pagamentos_ordem_servico` (`ordem_servico_id`),
  KEY `IX_fin_pagamentos_cliente` (`cliente_id`),
  KEY `IX_fin_pagamentos_fornecedor` (`fornecedor_id`),
  KEY `IX_fin_pagamentos_metodo` (`metodo_id`),
  CONSTRAINT `FK_fin_pagamentos_cliente` FOREIGN KEY (`cliente_id`) REFERENCES `cad_clientes` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_fin_pagamentos_fornecedor` FOREIGN KEY (`fornecedor_id`) REFERENCES `cad_fornecedores` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_fin_pagamentos_metodo` FOREIGN KEY (`metodo_id`) REFERENCES `fin_metodos_pagamento` (`Id`) ON DELETE SET NULL,
  CONSTRAINT `FK_fin_pagamentos_ordem_servico` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_anexos
CREATE TABLE IF NOT EXISTS `os_anexos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `url` varchar(500) DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `data_upload` datetime(3) DEFAULT CURRENT_TIMESTAMP(3),
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_anexos_ordem` (`ordem_servico_id`),
  CONSTRAINT `FK_os_anexos_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_avaliacoes
CREATE TABLE IF NOT EXISTS `os_avaliacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `nota` int NOT NULL,
  `comentario` varchar(500) DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_avaliacoes_ordem` (`ordem_servico_id`),
  CONSTRAINT `FK_os_avaliacoes_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_checklists
CREATE TABLE IF NOT EXISTS `os_checklists` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `item` varchar(200) NOT NULL,
  `realizado` tinyint(1) NOT NULL DEFAULT '0',
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_checklists_ordem` (`ordem_servico_id`),
  CONSTRAINT `FK_os_checklists_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_itens
CREATE TABLE IF NOT EXISTS `os_itens` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `peca_id` bigint DEFAULT NULL,
  `descricao` varchar(200) NOT NULL,
  `quantidade` int NOT NULL,
  `valor_unitario` decimal(12,2) NOT NULL,
  `total` decimal(12,2) GENERATED ALWAYS AS ((`quantidade` * `valor_unitario`)) STORED,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_itens_ordem` (`ordem_servico_id`),
  KEY `IX_os_itens_peca` (`peca_id`),
  CONSTRAINT `FK_os_itens_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_os_itens_peca` FOREIGN KEY (`peca_id`) REFERENCES `est_pecas` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_observacoes
CREATE TABLE IF NOT EXISTS `os_observacoes` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `texto` text NOT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_observacoes_ordem` (`ordem_servico_id`),
  CONSTRAINT `FK_os_observacoes_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_ordens
CREATE TABLE IF NOT EXISTS `os_ordens` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `cliente_id` bigint NOT NULL,
  `mecanico_id` bigint NOT NULL,
  `descricao_problema` varchar(500) NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'ABERTA',
  `data_abertura` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `data_conclusao` datetime(3) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_ordens_cliente` (`cliente_id`),
  KEY `IX_os_ordens_mecanico` (`mecanico_id`),
  CONSTRAINT `FK_os_ordens_cliente` FOREIGN KEY (`cliente_id`) REFERENCES `cad_clientes` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_os_ordens_mecanico` FOREIGN KEY (`mecanico_id`) REFERENCES `cad_mecanicos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10012 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_ordens_historico
CREATE TABLE IF NOT EXISTS `os_ordens_historico` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `data_alteracao` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `usuario` varchar(100) DEFAULT NULL,
  `campo` varchar(100) DEFAULT NULL,
  `valor_antigo` text,
  `valor_novo` text,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_ordens_historico_ordem` (`ordem_servico_id`),
  CONSTRAINT `FK_os_ordens_historico_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela oficina_db.os_pagamentos
CREATE TABLE IF NOT EXISTS `os_pagamentos` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ordem_servico_id` bigint NOT NULL,
  `valor` decimal(12,2) NOT NULL,
  `status` varchar(20) NOT NULL,
  `data_pagamento` datetime(3) DEFAULT NULL,
  `metodo` varchar(50) DEFAULT NULL,
  `observacao` varchar(200) DEFAULT NULL,
  `created_at` datetime(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
  `updated_at` datetime(3) DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP(3),
  PRIMARY KEY (`Id`),
  KEY `IX_os_pagamentos_ordem` (`ordem_servico_id`),
  CONSTRAINT `FK_os_pagamentos_ordem` FOREIGN KEY (`ordem_servico_id`) REFERENCES `os_ordens` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Exportação de dados foi desmarcado.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
