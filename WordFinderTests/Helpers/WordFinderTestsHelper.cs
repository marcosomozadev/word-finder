namespace WordFinderTests.Helpers
{
    public static class WordFinderTestsHelper
    {
        public static List<string> GenerateMatrix(int size)
        {
            var random = new Random();
            var matrix = new List<string>();

            for (var i = 0; i < size; i++)
            {
                // Generate a random string of characters for each row
                var row = new string(Enumerable.Range(0, size)
                    .Select(_ => (char)('a' + random.Next(0, 26)))
                    .ToArray());

                matrix.Add(row);
            }

            return matrix;
        }

        public static List<string> Matrix64X64 =>
        [
            "ahbprzdcbcohokqxnftblfjpqcufpivufmslnzgddrevibhdbozigicrbhczxfyp",
            "rfknppczxgfotbnpyhhtzqewrjcyyoklslvepmbcuzgxtqkgzckicdgvvsdqkrwn",
            "wnihmapfgersepajlobrxrtwjmlrfeabrpvimgrvefdwzgudkqtpzkrwimuiiusv",
            "tamejyttwyblbjbnldeqyzusioxsjaisheiqewypugnxkgqfyteefxxcyrnajnln",
            "jxfwvkkfstpypbljkuchnfdrxwjnbwlmrnemuauoumpptwjbjwlyeokjtplplztf",
            "ilaaknbejhiaiphhttakhotwnntjmsxubmalaspvuuvyexnnafnytymqzdenkihg",
            "ztauuyibtimberwpguitarmksiibamgoeadssudhynkvpbvgwvhlldsxlwijfyow",
            "tzdkyuofoosrqfptxbpennmqmyvezdmqfkqhmrerdrkdsrkmxedddsblmsdxznxr",
            "ffsbghnkhefizcgtqwghdpimemoleuaefliyekgnxnwquartzpnswgalwwvpgzim",
            "xklefbmnbiqfrkngzvwnekduoenflunrqlfjrpfocsiejiuhllqrkrgradusrecw",
            "bfxdpqvoitssqxkkioomhzdcolyjgzpmpunicornpgespuojycyardjpsnurjaco",
            "ecsvaoswgutvrxbjnwjtdihvvqvwtsxyofgcnkpgmfblvnpjumstqswamidbwlib",
            "upfckqopgabkybnghbfzhpptfqgojuxhzodmvwfnpspbdnipdiogifjomslzzzwm",
            "ijbkzohugztzokonstojrrgvqwxgbqolqrhuvjcqivfhnyrlwyairvstebgcpaqc",
            "xlujwcwcqbdfncmpqysshgekegwduizkqstvojmnltfxqtimkfreexuyfddpzsdq",
            "irtkpeocbnmmowotpvctnyhfgdxfcmeuasyxuvxehvcsjzmauecpmchgffeaqbof",
            "kmtbuieshsfjdtqcnyeymqgnjdyizwnqzawpadbamsxaotztndffwmkjktfpkxpg",
            "utejscrukkrpheqhxpqmfmxtxpuqwskmxcdxonpmzwjstikiepjsddknpacmqbtz",
            "zcrdqdmnflxtwmlkyusztatabbqraquofutmipwgveuajwvfnqierfxwcyqxdnfh",
            "zlfbziksuqolmbptrwolpjnnfmchpvkcwrnbpmyqepvoedahsmflmowihfjdtrrc",
            "vflgkqveqcjbkmdbszfhddewqeltrfvirlszxjxnmjdbincfkrkxqlvrdkjzupzt",
            "ukymznsteeozsjkmoxyutmxnjvyhpqvgkhqwboczagiduqaqbumunoirnfelodjf",
            "iltmgifekvppukazlqmdyxzcwfabygtjinvndbibeorxsbananatkbdnxjsrcfkr",
            "pmjukhuqhaffmvdhsigvfeopifnypbpzbepaokczfylckfosnrfzptdgyfihrwqz",
            "efpgrtijocsxrlghgrhuwpkmckbbnjcstsulsizgvczqbnzbsqlofkovnigpaphb",
            "ssmnlbagvblezmjnxnrfpdfmnplksoejhfoqvmrtthgwoxvmiiqtqkvnjbxkggwn",
            "cwaqpomdynxdndwdoupwindwknimfmzhhuqlcsiocxxmzrigtimmqejtjvlayrpd",
            "hxnyquvjrocstzanepbpmvekwbyvhorlzifygfbiulshwrdxyuzuiqeszntszwyy",
            "rddnwgzaqrrygcnzpsslwgbissnmzfecqslerymkytlrvxtjmrgyciegzbwttowi",
            "krgllpwxdeknlwtzzluekdaeyvqyehhnoxduvqhyjourneyjwudzepgttyllfewj",
            "nkufjnfzcfyweilrctfjxwcwfwydncpvqbhntnnbpqighadyzopewfmvuwqylfzn",
            "boqkmuqfbqhuomirhayjmqyihhcqrqsmjgomtogvugdissrfhoduoowaypcfymqp",
            "qpktoctfbdhyrwmzlejynrugxvxrfwdzkymkwmbdkffprqdjamyxzbyflsjwtanv",
            "dbqpawhtbrzubxogugkhjzhbihfsykeezwxbmapdnyivdmgbfzpdcrgmfgzzzvpj",
            "xmiectjovgqfpnmfhkttzemgguamluybcvtongjkwsmazhqwcfpldoijumltfdqo",
            "qzvmajgiblwkdjloltdgympljasxhsotwdrvmetefdkwcssvwmpxhqccyqerybbj",
            "bmotntdmodhrjugnmcamframutxlxgvzathuryltehjipndtpebwguskvlqjovwq",
            "ouzwgyolkaziuqsxvlszdroffmbdrftotzesrgyoxiavioletwixqmqsbfwznjbz",
            "hczixidlbcxyexiliaxbxbcxwopjzpcseagykznvvjklxehzagrdtqvkixliosub",
            "ngvgqkrligjurlljsjqanifqlbfhpeqvozaipnutsuyqdxgkmstationujdeximw",
            "vkxwijjhmehdbieunyvgutvkevsyoyajzkigiupxrurajiconnlrdohibaoeklqc",
            "hbdhfukugpqoxdnvdprgiatcfofirisdcdyqdjugeslmgtkzgcumxkajlhiempsl",
            "cmmnlpmguryrdzcmxdmkhdzqurwizwcycysxfrsmsmtqhmhkmyyukheskrcdtpsd",
            "xateozfymeajruekdcuuyvbenavltgnwrtccdspgtjspuuzrydqexlocmznjnpsj",
            "uwikpukzxjrjorezdqpsmxowunqihxmfbtpytnctmqtdzgcxhqhsomovadfrlihn",
            "biogkdzqbmxwafpuxqedkrdtvgqzipisfqrzaggfjfujrqhdtjwrizznjpconrya",
            "ljkganicrhdrmrqgnhfegpnjkeutpwcuucgifrucbrocketrtuxhpqgkxqlztfrc",
            "sbhzbirckpjqebqeiperhmfedxtgmnkrpwhflqwaoooebtxflbenbkmtyrszlvun",
            "mctcgtlkyytmqrnyvwvtpyagdgvejdaqwtyivranqzkjyygnpdntdfhssqbbpjaq",
            "tliocsenpzehrhvwswtfqlhoceqzfgksadtyttsjzcexnxrcpoaejxjstmsrwfnf",
            "sfpkqdsfrpbubynppfubwznftojtamkjorakuszhgarqlojiubqerrihctghpgmj",
            "kaoknicfxvwyjuhozcmuwsorwhcqfxibfkcnwmegwavxyarwfqclwycheduulqyj",
            "tqogtdjgrdtklqqorhuijfgrqhoysxhsxjjdoeohhoezvoraojmdbwxdginlkdab",
            "nildrubynbddpuecwnhzackolmiojhnyvkgjezrhqdwkahvlyrmrejqobcfnzdyw",
            "sgcjzkxjlimndpjmirlzeomaninuqmicjnrmoovzsvhmdflakyscfwdqutnakgir",
            "lyiwqzazvafcmmpdwvbmecikacnrnybuzxubnasmxjpxfsoctdayeyfrgicwpxri",
            "irncstkhhfcgjmbpralazdqabtcwrkztgqnrviunsjjxkshadowlkjaluexvhcdr",
            "bztdbawwvzkhzdxmiuehgwfocbagumorningikmnjbnasuhgryfllbckfqigakzr",
            "fjjahnceuqklgrcjexjolyibnbarpimdqezhfkzoryghzjtsumzzpafqphhubbdy",
            "psnfzpxqlrcoedtukjjecaizqgnjvaekqvlmfuwmbrbbtfpezaxboeqkhpohknlx",
            "sesiipllkvdyvjmjygvziudwjekfrucfdrfuepeiqxuszyatprksihhvmodlfree",
            "mnmoxejhezwdwwppxbmsvjrhimqbyzoftwisaczyaqairdiamondhabhsssfgftw",
            "jxpnveevpuvfxkwcdohfnqjqczkqspqqicgcxmlrelrroupdvhlauyzboryqqccq",
            "thsgaddyzlgmiwawqlnoanmrcixkrwbgsffwyqjsnqmqcnhmaheaxmklrgdyixue"
        ];
    }
}