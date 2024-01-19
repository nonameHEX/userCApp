﻿CREATE TABLE [dbo].[UserContacts] (
    [ContactId] [int] NOT NULL IDENTITY,
    [m_name] [nvarchar](20),
    [m_surname] [nvarchar](20),
    [m_privateIdNumber] [nvarchar](10),
    [m_address] [nvarchar](50),
    [m_phoneNumber1] [nvarchar](9),
    [m_phoneNumber2] [nvarchar](9),
    CONSTRAINT [PK_dbo.UserContacts] PRIMARY KEY ([ContactId])
)
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202401191835101_InitialCreate', N'CSVImporter.Migrations.Configuration',  0x1F8B080000000000000ACC58CD6EDB3810BE2FB0EF20E89C9AB183029B406E91B593C2D83A09AA34D7052D8D6DA224A52529C37EB63DEC23ED2BECE85FA26427768D6DE1832D72E69B1FCE7C1CF9DFBFFFF13E6E057736A0348BE4D81D0E2E5D076410854CAEC66E6296EF7E733F7EF8F517EF2E145BE7A594BB4AE55053EAB1BB3626BE2144076B10540F040B54A4A3A519049120348CC8E8F2F29A0C870410C2452CC7F1BE24D23001D9033E4E2219406C12CAE751085C17EBB8E367A8CE0315A0631AC0D89DF82F331147CA801A4CA9A10BAAC1756E39A3E88B0F7CE93A54CAC850839EDE7CD5E01B15C9951FE302E5CFBB18506E4979AA954570538BBF3598CB511A0CA9154BA820D1261247020EAF8AEC105BFDA41CE7292EF277877936BB34EA2C87631713A230DD8606C6756C7B3713AE52D97696F3331934342F9CC6FE455516583DE90777136E120563098951945F384FC982B3E00FD83D47DF408E65C279D34D7414F75A0BB8F4A4A21894D97D8165E17C617E16BA0E69AB135BBFD2EEAAE611CEA4B91AB9CE03BA42171CAA9A6864C33791824F20415103E11335182D1EE92C842CAB1D272C93E24F89DFA53D2C43EC29D799D3ED67902BB31EBB236CA27BB685B05C285CF82A197620EA1895C0EB5674A2FE1F43B1621BCCC42C7C48C402D40183C3F318A461A840EB0386DE9F29B27524218F6A78C0DAF5B98D8DCE6ACC2375BB774920EB0086C5DCEE083D5DA4BF60DBC707D8F30525E8C2603BB61CD9076361BA4EED49CECA4DFAE8F7BAF2AF667F92D37F794D903DF78437A7718CE96BDC1BC58AE31797C63BFF782E15390609740FA556DE5696902CE80AACDD342521DC33A54D7D594D42D123669FC69E4C97F6AC84DBE459E7BF54487F174A3D5768EB7C2CB03A9FF718A240F6CBA285CAA7F6B5D2D1CEEE71CAA9DACFC993882742BEC2F287B04AB26D02956BC7A05464DA06AA968FC1EAF0651BB3B37D0C76458D6DCC6AF9283F5BEC6739D9DA3B1175740075D487EA11ABE0ECF26E305D2169CD0376BF1C221C5BA4B25E118F45305ED1EC6F9856EDEECF455C07D3B56161DAF9FE4E1B1059230EFCBFF884338CB7169853C996A04D3E39E1553E1C59E3EECF337A12AD43FEF6F9F3074F802C4DF3AB335E67403C66E8931BAA8235559D69AC463D69C63B1BEE9E91AE177F7802BE35C1F5E2BE3FC5EF9E81AD17FCFABBB047DF837DEC3866CF098747ADD63C7578DACA3967EC868B08E3C9DD6D08E893E7B12E0D7AA4F96AEF4D41B3550D91BEE84B08527EA9414B99995C46E55960984D8F4A11EBA8E6606888D9BA55862D3110DC0EB0D8B241FA85F20445EEF014C3997C4C4C9C985BAD412C78EBC5CD2387ED674367DB67EF314E9FF4394240371986008FF2F784F1B0F2FBBECB35FB20D2C229080CBDC21709845B618C05D20316F3DB808AF44D210699D2DF33889823987E943EDD20C8F1BE61957D86150D76E56DB61FE4F58368A7DD9B32BA5254E802A3D64FFFAE22E9FF551FFE030000FFFF03005352B8D7E1120000 , N'6.4.4')
