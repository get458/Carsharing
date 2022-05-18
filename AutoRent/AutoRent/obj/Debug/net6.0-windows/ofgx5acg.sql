DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.AutoRent_Car')
AND col_name(parent_object_id, parent_column_id) = 'Name';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[AutoRent_Car] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[AutoRent_Car] ALTER COLUMN [Name] [nvarchar](max) NULL
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202205181050524_editCarName', N'AutoRent.Migrations.Configuration',  0x1F8B080000000000000AEC5D5B6FDCB8157E2FD0FF20E8A92DB21E3B79D91AE35DB8765C184D6223E32CFA16D0123D16AACB5417AF8DA2BF6C1FF627F52F941475E15DA4349CD124468185A3210F792E3C3C3C3CFCFABFDF7E5FFEFC9CC4DE13CC8B284BCFFC93A363DF8369908551BA3EF3ABF2E1871FFD9F7FFAE31F96EFC3E4D9FBA56DF70EB7433DD3E2CC7F2CCBCDE96251048F3001C55112057956640FE55190250B10668BB7C7C77F5D9C9C2C2022E1235A9EB7FC5CA56594C0FA1FE89F17591AC04D5981F86316C2B868BEA35F563555EF134860B101013CF3CFAB32FB0CD3D2F7CEE308A0F157307EF03D90A659094A34BBD32F055C957996AE571BF401C4772F1B88DA3D80B880CDAC4FFBE6A60C1CBFC50C2CFA8E2DA9A02ACA2CB12478F2AE91C882EF3E4AAE44AC8DCCDE23D9962F98EB5A6EBDC8BE5E80DCF7F8014F2FE21C37EEDB1DD11DDE78EDBFDE74FA476682FFF7C6BBA8E2B2CAE1590AAB3207F11BEFB6BA8FA3E01FF0E52EFB174CCFD22A8EE9B9A1D9A1DF980FE8D36D9E6D605EBE7C860FCD8CAF2F7D6FC1F65BF01DBB6E541FC2C7755ABE7BEB7B9FD0E0E03E869DEA299E576596C3BFC314E6A084E12D284B9823CD5D87B0169E303A3716FE6F3B1AB235B4587CEF2378FE00D375F978E6A33F7DEF2A7A8661FBA599C19734426B0B752AF30A0E0D729B4701BCCA72B43A907083B21DF01206510262DFBBCDD15FCDC2FDD1F75601C0CCCA38D70F84C90AD2D377B9AA606CD9E52E07699144059EF0B0AE385A9FC053B4AE55C751ED4C15CFC8F73EC3B86E553C461BE21A1863FECA35BFCAB3E473868755B7FABACAAA3CC0EACE069BDE817C0DCB11B3A78563C105DB6D881BBAB521574C97F1DC2155DB7055371FE406B532E5023795CD7EB9E89DA5990B257663E343718F5727AAF02144D55B75A4F63A6557918D6EE99EAF3A1E70FAF3D0753D092B1DA3EFAFBA95E816B9D859A8B48F8FAC42DBA6D7AB6A25AA4547A8DC3A4613CD632A895509F2F21245E85DE88BFEBE4307476B4A57511A158F5B21D51A4E1D9E3B8BC92F611CA163F9CB7918E6B0288662EDE118AC3EFB6943B086AFAF6C175918266BA909C5A4CD4707939C646C9912BA1B31C8F5B26196EF3A9A71BC286DB9257D8C58C44D6DF8AADB6F27A8167462E3C8B9CEAFFE5CE6B3EA9C86E37C05220CB12D381EE66F5514E3F4A4F3812EA322C8A30D49CAED39C621EBD86659E01EAF6B4166A6559EEE227DB7931CE10750943BE1E643B68E52F7294F5014BF6679E87EA0C72C859FAAE41E2F2BD77E24C7FBD307142DA6C5AEC6C4BBB7657E16CB7E93E5E5F450B3A5A40F56EAF841D24712ACC89BAA831545FBD19117266FC30C693FC808FED19489BAED76A2AD5ED436FB49DBEB754F91ED29308F60E17E4BD98DF3B82E8A0ADEC6E8BA7537438D3896DB5B3D599336168F7BBC5ABB62737110DDA8747A5E145910D5EA922435B82B3DD6DADEA7A1677EBF4798E1EFA5105FE8963BDAA07B6D34B933FF2F824D1B8DD2FA6ED928E452891DE6F8E8E8441809DD90C31C5F5183181DC80B74228FD252BC4E8FD220DA80D878521C05C32B79ACB16E2CFE974BB88129BE4D3796BFC924DA6B677122DD785CD5C090C4960BCABCC6581D7379646717F2FB58575628BDCA958DC65E87B1C39EF06A5ADEA42801034BE89D07A4FAE50214010845CF8F5677E8CC9A65CCEDCDAA657A35990C5F2131272BC7173D96F6C6DCCF3BB36AFA6A5F6ACDF515D56E7D2B3DA9FD5921257F23EB6BAA80F66C75D25B88619BD05F49C8ACAFBB351C6382DA2B0D43639F932FD5F1B3530BD6E9D16422CDADE3DC8C98BFE1186161CA2B28F7C6ADBAC2920D2DDCE5B877BDA6F3DDAF212BF4673229C965F07E0D5C91BB1B34ADA1449EC49EC8CDC708331E4802DE49C6EA3363CE8D563FBB5D5AAA5E272633A133C773B2CB3AE56369276C4ED69D3D32F95CD938245FB5633BA467B53F1BA47560328BF6B2636E9B7E6D2A23B65BB612C3FDF6CE547298DAFCACA3579AA3FDEEFAB42E4D66D256DEEDC09649B6154F19F5803955DE069F659743686A4DB6BC68D2B7BCAD617A2B5836940015C2A338B04FEE4ACF460B43623805A8A54692A9A6E4E89C8B962C9B1533268FA5A5255BA7274CC9B5F6A51767E71D4CC972F1A57EC642806F3A0A366D2D65E2664CC9B5518796641FD19992C52B5A4B926CCC1C396A89F53435D7141ED561F89D12EF0BACAE353A4E851529F818AB8B0C19DD6671F2FE9E95CE68C9B14BD05482EA04FDD814FD16252A4DCACBE8737ECA95846B6F642C5921296C9B16DEA624E944B05482C4156F5172F282699DF486939B63D29B5229F63B859128B5094D53356D579AC2466325596DC66D6ACECD89C4555936D960921D7B7BAA50556669E46F92101A95129231DF041226521E4802C9A85371852B919210C2589C621EC33A93B1553132B90B19E5268672E91C48AC68E511C4E3F8A803B993B5CF1CC18D95A511695B4CD31DEFBADF960B02AAD17C582E14E81BCB8F60B341753D141A47F3C55B11288E8B1F56F6681509A1B1081897CC1F46BB91CA2C076BC8FD8A4FA921BC8AF202BF0E03F70057165D8489A41939CC2A62FF7614D9795554637B20687BE1BF593B658FB4E271BFE97985584A70F6A046A1A0B4ADEF8E08E0E7642097005F5C647195A4EA6486BA3729E4A2FB932FE614449C0A9A9AF8AB39652C619EBBF69B3995B66888A672A52824D2CC852BCE60E63450B8815719A77B21BD23D8979033638DD6CEA431BF536D1AD39862D4F2FE6EAC1A8F450E33BCD66509973968883DE04DD394EEC86BA3313D1D379A131103542B6DB69AAC0F9A133528395A5B694EDADF8DC63A1C009A44F7717EFAE983B5897B7CBBA34DD9E89534DCE8AABD5EA029A8AE1CB41AE78928EA6ED434A8B7FD341DEAB385B7A75EF733FE9EFA6EC11DFBC09FE192FDC99CA6A48283A66B50E0B1FF7523E61CA6AD9F810C8DCD321A24E5C8F3D5CFAA19039180C7E928B46FA6D92540BE9953E99F44D374FAAF16764ABF79662C94FE617EB6498EC7D3EC51961FB03142797F3796D73D62660CA7FDB8CBD35FFF0299A6D27FB5A0449E183364C8278BB368F780983983765F2D28D12F841962F40F162B4BF60A985961B206E6F4DB22189AA4AA30462FBFB6948B97A0AAC46BFFABBF4FD94EF300AABCB58D1750D370E4099AA7A78C2368BE59F8018941DADB20FD7094E188FA6E494D0CEAA8CFF3B34492F99E6685B274BF8D05CAFBBBB1BEFE2928EF7754FB88530D09596FBE49377A97FDE6B2DCCB26E33C0C442DA4A049130C01963D45214E3FAF5E8A122647B8C1D1EADFF1451C217EFB061F411A3DC0A22458C9FEDBE393B71CAAF57C10A6174511C61630D33B077D46456FBE3708EB6C89C2468C980C903E813C7804F99F12F0FC679AD2142CE7D02D96732D14A190EF1A95113E9FF9FFA9BB9C7AD7FFACD345D7976FBC9B1C99E5A977ECFDD796C136A16E372EE935655C39AAB431DF39DD5B358FADE00F88D9EF835D157D1ADD7A654C04E7FD36E4A702C5752B47F105EFA1CA8F039E752A367982F66045C702BB9ABA49D2CBC23D4A75663F6EDD69D2B002826C58FF3D193D76141929726CB833E45853A90B04CCF7E7E9D09FDFC632A3F13627C58D2CA6E624523C6EE62462126C4CA76E58F294EA506D83C39F9CA486AD9D4F781CC969C468ACC869C7260E0F721A3111F371DA1A50E33A4EA2CB62379A7A6DD26BCA514A0480341DBBEFE972AB503C333F583FC060064E7303DB333E11FB6F3A39CBC06924B6DFB761153CB6DE1676D5EDE2E7D5ADA6A1D8C99FF24C00899AF67C5851D7E814A6E9FB40BB631FEC0DBFAA75F8C27C66363750A1B97FDB3B782C3A3A433412116E6E3623AF099D81AD284AF20F03390E986BD4B947E26E87C6A27E4C8632DC0B68C67785EF263C6E35825A18E9B4666156C3E59E3331B16F066DAD7FB9AB87C6186755E405A61AC7C3AD35694AB5DCC2547D078868E479B21AFBE410ED45515435035B396CF4323BAD7E1F0194B1EAF7B2BDCD00618C7FBBAD87666223F2011831528487F28CF7193202922A635B2C0C4723E9AC219C31ED78A489E9806C2EC414894C3B012BD032EE803C8459A61F58F2F64FA3D86E619AA09AE9556C0A7EA60EB22DA0CFB453B1054AE33CE7104E9A766C23283549286882A4A61DD818708D8B2986F0D6B483CE13928D76209297F0A203566527540811878DB32673779AE7E733169713D034DA094BDE76CF4B1C3B4442B360692846D43EC8FEB6A0CD149B9CFE15ED4CC5B95378327E6B543CF6321215BDAF4B9E8E1E1ADC18BD714B5E20CD4C243B8510FB62C5D68E1696052498F8080A9D022BD43B219505E8285A44EB9EC412D14C617D82EF89B66DAED387AC3D8672336A9B7045101F610950A10838CFCBE8A12E98CD02E490EAE2C55F405CA126EF51C54B789DDE54E5A62A11CB30B98F9997F7F838AB1BBFC63D63E7BCBCA90B1A8B6DB080A619E15A979BB4AEBBECE67D25A9775190C0E7E4A6B204EB12A9BB846BC46343E913AA663323D488AF3BDEDFC16483FEAF6C617193AEC01322623F3764C61FE01A042FED5B3635916145B0625F5E46609D83A46868F4FDD13F910D87C9F34FFF070000FFFF0300D4DBBE79BA920000 , N'6.4.4')
