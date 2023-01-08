rule Fin4_VBA_Keylogger_Download
{
    meta:
        description = "Identify vba associated with fin4. Inspired by https://github.com/mandiant/iocs/blob/master/FIN4/MACROCHECK.yara with the additional ability to identify vba which also can download a keylogger"
        author = "stvrsxz"
        version = "1.0.0"
        hash1 = "ead9a3b68f3e6f6788d64a9e47ddb29329c978daaaa3d4ab736de6a02efa2887"

    strings:
        $PARAMpword = "pword=" ascii wide
        $PARAMmsg = "msg=" ascii wide
        $PARAMuname = "uname=" ascii
        $VBAWinVersionString = "Technically could be run against remote computers" ascii wide
        $upload = "upload" ascii wide nocase
        $keyloggerPE = "WINWORD32.exe" ascii wide

    condition:
        all of ($PARAM*) and $VBAWinVersionString and $upload and $keyloggerPE
}
