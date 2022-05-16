ALTER TABLE [dbo].[AutoRent_Contract] ADD [StartDate] [date] NOT NULL DEFAULT '1900-01-01T00:00:00.000'
ALTER TABLE [dbo].[AutoRent_Contract] ADD [FinishDate] [date] NOT NULL DEFAULT '1900-01-01T00:00:00.000'
ALTER TABLE [dbo].[AutoRent_Passport] ADD [IssueDate] [date] NOT NULL DEFAULT '1900-01-01T00:00:00.000'
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202205061818362_AddDate', N'AutoRent.Migrations.Configuration',  0x1F8B080000000000000AEC5DCD6EE4B811BE07C83B083A25C1ACDB9EB96C8CF62E1C7B1C1899B18D69CF22B7012DD16D21FAE950D2AC8D204FB6877DA4BC4248513FFC1729B5BAD533468085474D16C9AA62B158ACFAF2BFDF7E5FFEFC9CC4DE5788F2284BCFFC93A363DF8369908551BA3EF3CBE2F1871FFD9F7FFAE31F96EFC3E4D9FBA569F78EB4C33DD3FCCC7F2A8ACDE96291074F3001F951120528CBB3C7E228C8920508B3C5DBE3E3BF2E4E4E161093F0312DCF5B7E2AD3224A60F50FFCCF8B2C0DE0A62841FC310B619CD7DFF12FAB8AAA770312986F4000CFFCF3B2C83EC1B4F0BDF3380278FC158C1F7D0FA469568002CFEEF4730E5705CAD2F56A833F80F8FE650371BB4710E7B09EF569D7DC7601C76FC902165DC7865450E6459638123C7957736421761FC457CAD69A67EF316F8B17B2EA8A6F1DCBBE5C00E47BE280A71731228DBB76476C87375EF3AF37ADFCB19A90FFBDF12ECAB828113C4B61592010BFF1EECA87380AFE015FEEB37FC1F42C2DE3989D1B9E1DFE8DFB803FDDA16C0351F1F2093ED633BEBEF4BD05DF6F21766CBB317DE83AAED3E2DD5BDFBBC183838718B6A267D6BC2A3204FF0E53884001C33B50141061C95D87B0629E34BA3016F96FDF68660A77280AE05586B0EA63CE054543ED1206510262DFBB43F8AF7A57FEE87BAB0010DAEE0311B2126BCC5DAE4A183B76B94720CD93282713EE178440EB067C8DD6955C04AAAD1E9219F9DE271857ADF2A76843F73DA7A95F84E657284B3E6564587DAB2FABAC44019165D6DBF41EA0352C06CC9E658EC32AF86E7DAB615B5BAE8AEB327C7558D42EABAA9AF7AE06B7B25D0569AA9AFD72D159423BFB48F5C6C540921EAF16526343A8A829EBF0898C5D0ADFFB089E3FC0745D3C9DF9F84FAC08D1330C9B2FB579F89C46D803C19D0A54C2B132E577918B6CD99EAF32EE31FAF3907535092719E3EFAFB255C8169BD85988B4F38F9CFCD6BAD7AB6815A2C5F723E4ECA3C9EA3196C4AA00A8B8C4EE77EBFAE2BFEFF1ADD099D2559446F9D35648358A53B9E793F9E497308EF09DFBE53C0C11CCF33E5FBBDF07AB2E764617AC5ED717BE8BCA0D53B534B862CAE6839D498133AE8B92BA5B2D50E8E5B258B1EBE085934DE9BA5ADAC76A89A4A9CBBAAAF6DB71AA2599B81872A1F3AB3D57D9AC2A60B1D5735A65AD1124BA30F1307F2BA398C41E271FE832CA03146D68C46DCF3E0EDDC72EDB82F478DD0B2A352D51CAC4E626539F9B5D0CF201E4C54E56F3215B47DBDE068A9027C8F35F33144E3FD05396C29B327920DB6A6A3B82C8F9F4017B8B69BEAB31C9E9ED189F25BCDF64A818EF6A3694CCCE4AE53F28FA289C157553BDB3A2693FD8F322E45D1643DBF72E84FC68BB88AAED76BCAD8ED52EE749D3EBF54C519D291045309FFE48D98DF1B8CEF312DEC5F82D7537430DB896BB6B3DDD932E1A4F7ABC6ABBE67099C0BBD1C9F43CCFB320AAC4A5086A084F7ABCB6BD4F43CFFE7D8F2E467C97C2EBC24FD8D1063F5AE3C99DF97F9174DA6A94C676AB46A18F4AFC30C7474727D248F8F91B22F2FE0C627C21CFF18D3C4A0BF9AD3C4A83680362EB4909142CDFDB89C4DAB1C45F2EE106A6E4A9DC9AFF3693689E9DE589B4E30929017D1C5B2E18F51AA275DCE3919B5EA8DF63A7D242E553AE6A34FE398C1FF64414D3F236C501185840EF3CA0A92D17200F40285B7EBCBBC3C9B459B5B8BD69B54AAE3693113324E6A4E5E4A1C751DFB8F7F9C9B49A7DDA576A73F544B55BDBCA4E6A7F5AC8F0DF4AFBEA2CA03D6B9DF215A25F27CC4F122AED6B5F0D87A8A0F149C352D9E7644B4DEBD9A9069BE4683391FAD5716E4A2CBE700CD030ED13D4F4CAAD7BC2520D2DBDE54C6F7A6DE7BB5F45D6C8CF66528AC7E0FD2AB82676D7AB5A7D813C853ED1978F016ADC1304548DD545C626575AF3EC76A9A96699D8CC848D1CCF492FAB908FA39EF031D9E9F4918BE7AAC6A1F1AA1DEB213BABFDE9202B039B59348F1D733BF42B551970DCF29918D31FEF5C2687ADCECFDA7B6557B4DF539F95A5CD4C9ACCBB1DE8328DB69229E31E1031E96DF059F53884A75647CBF33A7C2BEA1AA1B782454D09302E3CF603BBE0AEF26EB4B024464280466A34986A4B8E8DB918C9F251316BF2845B46B25578C2965CA35F6676B6D6C196ACE05F9A672C39F8B6A310D53652A666C6965CE3751849761E9D2D59B2A38D24E9C12C9063B65847D3F04CE1311DFAEB94445BE0F4ACD1AE54DA91928D717AC850D1AD37A768EF79EE0CE61CBF056D39A80FD00F0DD16F91A3CAA0BC8ABE60A7A6E270658DAC392B05855DC3C2DBE4241B085672909AE22D724E9D306DE25E7F7073487853C9C5EEA4B062A531A0692BA6ED72533A689C386B8CB88D8DB94DC2715D944D3598E2C4DE9E2874995906FEDB0484068584548BAF1D091B2EF7048154D419BF622A965217C29A9D721CC33992B1553672B10B15E5DA879AD238505FD1C922C8D7F14117F249F63E7705B7169681A54D324D7BBD6B7F5B2E286246FD61B9D0406B2C3F82CD06E7F530501BF5176F4571362E7E58B943512494C622E04CB278196D472A3204D650F895DC52437815A19C5487810740328B2EC244D18C5E6635BE7F338AEABE2A8BB1B91034BDC8DFBC9EF2575AF9BA5FF7BCC24B4A48F4A0829860A46DEE8E099072328014A81617595C26A93E98A1EF4D13B9D8FEF48B3D0519A782A526FF6A4FB9799266E9E99EA9F5549AA421968A2E91C83017C427677073127E93A92E1782ECA5F08EA45F52CC8C575A3795A617B3713AADBA8ABA28B5BAFF345ADD610B885257055CE62021FE82374E52A62BAF8BC4CC74A6919C8C18A0DB69B3956475D11C2941C5D5DA4972CAFED348ACC5016049B41FE7279FCE591B79C63727DA98835E4B631A5935CF0B2C05DD938351E222114DDE8D9E0653DBCFD2613E3B587BA6BA9FB3F7CC7787D5F105FEDC2AF99FEC692A323858BA16091EFBDF3772CC61DCFEE989D0B86CA35E521359BEAAAC9A531005329C89425333CD6F01FACD9E4A5712CDD2E9BE3AE8295BF3CC6928FBC3FC74935E8FC7E9A32A3EE0A284EAFED3685E5BC4CC294EF37197B7BFAE0299A5D27D75A0444B8C3932F493C35DB42D20E6EEA0ED57074A6C8530478CFDC16167A9AA80B91DA66A604FBF49826149EA1263CCFC6B52B9440EEA52BCF6BFFBBB90ED380BA08B5BBB58013D8D892C415D7ACA1982FA9B831D5028A4BB0EB285A3DC8A98EF8ED464A78EF93C3F4DA491EF715AA80AF7BB68A0BAFF34DAD795828A7647778E4C2A2129EA2D3669476FA3DF42947B59479CFB51A6A510346D4220C0B2AF5148C2CFAB97BC80C9116970B4FA777C114778BD5D838F208D1E615E502064FFEDF1C95B01B27A3EF0D18B3C0F63070CE99D233AE3A437DFEBC56C764461A34ACC0CB02508E7705A08E76AAA52FEDE35CE1E7C3EF3FF537539F5AEFF594589AE2FDF78B7086BE3A977ECFD971DD8A67E9FC781B61D97F61A33AE1A4CDA7ADD5C6FDD3C1EB7013BA0284A3FD4CD20E2F5A65F010A9E00FA53029EFF6C16E0484CDE6F837F3A2CDC69F92817EE1E2AFF04BCD949D9A68ECB1E2CEB783C575B33497B399847A5CCDCC7AD3A8D1A56028E0DABBF4783C60E22A3048C0D7706186BCB758980FDF93C1EF1F3DBD8662CCCA68379EA83D21C454A84CB1C454C018939A9195654501DAA6E08B093A3C4C05E4B461112E123C7116321224751126120C71193A11EC7ED013D9CE328BA3C64A3ADD5A6BDC65CA564DC47DBB1BB9E531E159AEAF283B5031C54E03833B03DE59321FFC69373749C0642FA7D1B5A2142EA6DE154DD2E6C1EAD5AD3D75B5A14AAAB2B784660438DAB1AD6A4334E8ACEF47D80DCF1757AFDC5B4131696CF4CE77A1233F7AF7B070F41C746880602C1CD4D67D4A9A033D0154D26FE6100C63948F4646A8B24BC0E0D05FB188D60B817AC8CEF0AD64DAA69B542581868B466A156FD599E3351B16F0664AD2BD83523620CD32A5A78A987EF98569B0C195AD3A2537D074068B42A590F797288FAA2C9A59A81AE1C3668999B54BF0F07CA5AF47B39DE66002C26966C9B1199788FBC073D8CE6DEE138E34386958086CAF8160BCBD16838AB0F5ECC389E1502992616620B40669C801356997041EE832A330FAC28F93308B6DD983660666611DB629EE99D6C07C433E3545CF1D104CBD9078F661CDB0A414DE10ADA00A81907B6C659137C8A3E9835E3A0F34462630D88A2005E36C0BAE8840E18E2B0E1D554E6CE50753E63764D8295C61A614549F7BCD8B14300348725F5F988C63AEC6F0BD14C73C8998B6767CACE9DA2928947A3A6C6CB8A55ECB9AEA8183D349431F6E056141ECD8C253B450EFBECB4AC1D6D2C072430B9F609DF024BDC3BA19905F82A9A47EB8EC412D34C617583EF88366DAED3C7ACB9860A336A9A0849101F610170A208384745F45825CC6601364855F2E22F202E7193F738E325BC4E6FCB62531678C9307988B9827B729D358D5FC19DF1735EDE56098DF9369680A719915C97DBB4CABB6CE77DA5C877D19020F7E43AB384C8128BBB806BBCC69AD20DCE66B32354B3AFBDDEDFC36483FF1F6C617E9BAEC0574CC47D6E588D3FC035085E9A12363D917E41F06C5F5E46608D4092D734BAFEF89F5887C3E4F9A7FF030000FFFF0300E33C06F38E920000 , N'6.4.4')
