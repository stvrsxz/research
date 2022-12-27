rule UpDocX
{
    meta:
        description = "Identify UpDocX VB.NET PE associated with fin4 activity"
        author = "stvrsxz"
        version = "1.0"
        hash = "d22df444e867fdf647f6757547b2b75968453c3bb398a5d94c5e17a5e57af7f6"
        hash = "629e8270c623002157cb38fe0f612665f22094cdc479c36452ee8fdc5d73326b"
        hash = "38fbbd70ea14e78d44b9b841a4bccd65c7051c7cb59b28c186c16e964399845a"
    strings:
        $s1 = "htmlUpload" ascii wide
        $s2 = "Enloggment" ascii wide
        $s3 = "Logment" ascii
        $s4 = "Uploader" ascii wide
        $s5 = "UploadFile" ascii wide
        $s6 = "exportLog" ascii wide
        $s7 = "generateNewLog" ascii wide
    condition:
        all of (s*)
}