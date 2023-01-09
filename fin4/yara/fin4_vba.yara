rule Fin4_VBA
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
