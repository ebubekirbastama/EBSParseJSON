        public void EBSParseJSON(string s)
        {
            ArrayList ary = new ArrayList();
            Regex r = new Regex("\"(?<Key>[\\w]*)\":\"?(?<Value>([\\s\\w\\d\\.\\\\\\-/:_\\+]+(,[,\\s\\w\\d\\.\\\\\\-/:_\\+]*)?)*)\"?");

            MatchCollection mc = r.Matches(s);

            Dictionary<string, string> json = new Dictionary<string, string>();

         
            foreach (Match k in mc)
            {

                if (k.Groups["Key"].Value == "EBS")
                {
                    MessageBox.Show(k.Groups["Value"].Value);

                    break;
                }



            }

        }
