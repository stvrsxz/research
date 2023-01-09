rule UpDocX
{
    meta:
        description = "Identify UpDocX VB.NET PE associated with fin4 activity"
        author = "stvrsxz"
        version = "1.0.0"
        hash1 = "d22df444e867fdf647f6757547b2b75968453c3bb398a5d94c5e17a5e57af7f6"
        hash2 = "629e8270c623002157cb38fe0f612665f22094cdc479c36452ee8fdc5d73326b"
        hash3 = "38fbbd70ea14e78d44b9b841a4bccd65c7051c7cb59b28c186c16e964399845a"
    strings:
        $s1 = "htmlUpload" ascii wide
        $s2 = "Enloggment" ascii wide
        $s3 = "Logment" ascii
        $s4 = "Uploader" ascii wide
        $s5 = "UploadFile" ascii wide
        $s6 = "exportLog" ascii wide
        $s7 = "generateNewLog" ascii wide
    condition:
        all of ($s*)
}


rule VBA
{
    meta:
        description = "Identify vba associated with fin4. Inspired by https://github.com/mandiant/iocs/blob/master/FIN4/MACROCHECK.yara"
        author = "stvrsxz"
        version = "1.0.0"
        hash1 = "ab385c7bcb2ad420ffe04d34705ca3e94981f80d7d0c95fb26241e4857aa8a9a"

    strings:
        $PARAMpword = "pword=" ascii wide
        $PARAMmsg = "msg=" ascii wide
        $PARAMuname = "uname=" ascii
        $VBAWinVersionString = "Technically could be run against remote computers" ascii wide
        $upload = "upload" ascii nocase

    condition:
        all of ($PARAM*) and $VBAWinVersionString and $upload
}


rule VBAwithKeylogger
{
    meta:
        description = "Identify vba associated with fin4 (see rule VBA) which also have the ability to download a keylogger"
        author = "stvrsxz"
        version = "1.0.0"
        hash1 = "ead9a3b68f3e6f6788d64a9e47ddb29329c978daaaa3d4ab736de6a02efa2887"

    strings:
        $keyloggerPE = "WINWORD32.exe" ascii wide

    condition:
        $keyloggerPE and VBA
}