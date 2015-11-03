Public Class Core

#Region "Private"

    Private Shared _bannedwords As String() = {"anus", "arse", "arsehole", "ass", "ass-hat", "asshat", "ass-jabber", "assjabber", "ass-pirate", "asspirate", "assbag", "assbandit", "assbanger", "assbite", "assclown", "asscock", "asscracker", "asses", "assface", "assfuck", "assfucker", "assgoblin", "asshat", "asshead", "asshole", "asshopper", "assjacker", "asslick", "asslicker", "assmonkey", "assmunch", "assmuncher", "assnigger", "asspirate", "assshit", "assshole", "asssucker", "asswad", "asswipe", "axwound", "bampot", "bastard", "beaner", "bitch", "bitchass", "bitches", "bitchtits", "bitchy", "blow job", "blowjob", "bollocks", "bollox", "boner", "brotherfucker", "bullshit", "bumblefuck", "butt plug", "buttplug", "butt-pirate", "buttpirate", "buttfucka", "buttfucker", "cameltoe", "camel toe", "carpetmuncher", "chesticle", "chinc", "chink", "choad", "chode", "clit", "clitface", "clusterfuck", "cock", "cockass", "cockbite", "cockburger", "cockface", "cockfucker", "cockhead", "cockjockey", "cockknoker", "cockmaster", "cockmongler", "cockmongruel", "cockmonkey", "cockmuncher", "cocknose", "cocknugget", "cockshit", "cocksmith", "cocksmoke", "cocksmoker", "cocksniffer", "cocksucker", "cockwaffle", "coochie", "coochy", "coochie", "cooch", "coon", "cooter", "cracker", "cum", "cumbubble", "cumdumpster", "cumguzzler", "cumjockey", "cumslut", "cumtart", "cunnie", "cunnilingus", "cunt", "cuntass", "cuntface", "cunthole", "cuntlicker", "cuntrag", "cuntslut", "dago", "damn", "deggo", "dick", "dick-sneeze", "dickbag", "dickbeaters", "dickface", "dickfuck", "dickfucker", "dickhead", "dickhole", "dickjuice", "dickmilk", "dickmonger", "dicks", "dickslap", "dicksucker", "dicksucking", "dicktickler", "dickwad", "dickweasel", "dickweed", "dickwod", "dildo", "dike", "dipshit", "doochbag", "dookie", "douche", "douchefag", "douche-fag", "douchebag", "douchewaffle", "dumass", "dumb ass", "dumbass", "dumbfuck", "dumbshit", "dumshit", "dyke", "fag", "fagbag", "fagfucker", "faggit", "faggot", "faggotcock", "fagtard", "fatass", "fellatio", "feltch", "flamer", "fuck", "fuckass", "fuckbag", "fuckboy", "fukboi", "fuckboi", "fuk", "fuckbrain", "fuckbutt", "fuckbutter", "fucked", "fucker", "fuckersucker", "fuckface", "fuckhead", "fuckhole", "fuckin", "fucking", "fucknut", "fucknutt", "fuckoff", "fuck off", "fucks", "fuckstick", "fucktard", "fucktart", "fuckup", "fuckwad", "fuckwit", "fuckwitt", "fudgepacker", "gay", "gayass", "gaybob", "gaydo", "gayfuck", "gayfuckist", "gaylord", "gaytard", "gaywad", "goddamn", "goddamnit", "gooch", "gook", "gringo", "guido", "handjob", "hard on", "heeb", "hell", "ho", "hoe", "homo", "homodumbshit", "honkey", "humping", "jackass", "jagoff", "jerk off", "jerkass", "jigaboo", "jizz", "jungle bunny", "junglebunny", "kike", "kooch", "kootch", "kraut", "kunt", "kyke", "lameass", "lardass", "lesbian", "lesbo", "lezzie", "mcfaggot", "mick", "minge", "mothafucka", "motherfucker", "mothafuckin", "motherfucking", "muff", "muffdiver", "munging", "negro", "nigaboo", "nigga", "nigger", "niggers", "niglet", "nut sack", "nutsack", "nigress", "panooch", "pecker", "peckerhead", "penis", "penisbanger", "penisfucker", "penispuffer", "piss", "pissed", "pissed off", "pissflaps", "polesmoker", "pollock", "poon", "poonani", "poontang", "porch monkey", "porchmonkey", "prick", "punanny", "punta", "pussies", "pussy", "pussylicking", "puto", "queef", "queer", "queerbait", "queerhole", "renob", "rimjob", "ruski", "sand nigger", "sandnigger", "schlong", "scrote", "shit", "shitass", "shitbag", "shitbagger", "shitbrains", "shitbreath", "shitcanned", "shitcunt", "shitdick", "shitface", "shitfaced", "shithead", "shithole", "shithouse", "shitspitter", "shitstain", "shitter", "shittiest", "shitting", "shitty", "shiz", "shiznit", "skank", "skeet", "skullfuck", "slut", "slutbag", "smeg", "snatch", "spic", "spick", "splooge", "spook", "suckass", "tard", "testicle", "thundercunt", "tit", "titfuck", "tits", "tittyfuck", "twat", "twatlips", "twats", "twatwaffle", "unclefucker", "va-j-j-j", "vagina", "vajj", "vajayjay", "vjayjay", "wank", "wankjob", "wetback", "whore", "whorebag", "whoreface", "wop"}
    Private Shared _censorword As String = "******"

#End Region

#Region "Public"

    ''' <summary>
    ''' Returns the list of banned words.
    ''' </summary>
    ''' <returns>Array, containing the banned words.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetBannedWords() As String()
        Return _bannedwords
    End Function

    ''' <summary>
    ''' Set the banned words list.
    ''' </summary>
    ''' <param name="bwords">Array, the list of words to ban.</param>
    ''' <remarks></remarks>
    Public Shared Sub SetBannedWords(ByVal bwords As String())
        _bannedwords = bwords
    End Sub

    ''' <summary>
    ''' Sets the word that is displayed when a banned word is removed.
    ''' </summary>
    ''' <param name="cword">The word to set.</param>
    ''' <remarks></remarks>
    Public Shared Sub SetCensorWord(ByVal cword As String)
        _censorword = cword
    End Sub

    ''' <summary>
    ''' Gets the word that is displayed when a banned word is removed.
    ''' </summary>
    ''' <returns>String, the word that is used.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetCensorWord() As String
        Return _censorword
    End Function

    ''' <summary>
    ''' Censors any banned words from the string. Replaces them with a customizable replacement string.
    ''' </summary>
    ''' <param name="txt">The text to censor.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CensorString(ByVal txt As String) As String
        Dim censored As String = txt
        For i As Integer = _censorword.Count - 1 To 0 Step -1
            censored = censored.Replace(_censorword(i), _censorword)
        Next
        Return censored
    End Function

#End Region

End Class
