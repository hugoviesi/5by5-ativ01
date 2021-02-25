using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Ex01
{
    class Arquivo
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }


        public void InitializeFile(List<Contato> contactList)
        {
            if (!File.Exists($@"{FilePath}\{FileName}.{FileExtension}"))
            {
                using (StreamWriter streamWriter = File.CreateText($@"{FilePath}\{FileName}.{FileExtension}"))
                {
                    streamWriter.WriteLine("Nome,DDD,Numero,Tipo");
                }
            }
            else
            {
                String[] contactFile = File.ReadAllLines($@"{FilePath}\{FileName}.{FileExtension}");
                Boolean isHeader = true;
                if (contactFile.Length > 1)
                    foreach (var contact in contactFile)
                    {
                        if (!isHeader)
                        {

                            String[] atributes = contact.Split(',');
                            Contato pessoa = new Contato
                            {
                                Nome = atributes[0],
                                telefone = new Telefone
                                {
                                    Tipo = atributes[1],
                                    DDD = int.Parse(atributes[2]),
                                    Numero = int.Parse(atributes[3]),
                                }
                            };
                            contactList.Add(pessoa);
                        }
                        isHeader = false;
                    }
            }
        }

        public void WriteInFile(List<Contato> listaContato)
        {
            using (StreamWriter streamWriter = File.CreateText($@"{FilePath}\{FileName}.{FileExtension}"))
            {
                streamWriter.WriteLine("Nome,Tipo,DDD,Numero");
                listaContato.ForEach(contato => streamWriter.WriteLine(contato.ToConversor()));
            }
        }
        public void WriteInFile(Contato contato)
        {
            using (StreamWriter streamWriter = File.AppendText($@"{FilePath}\{FileName}.{FileExtension}"))
            {
                streamWriter.WriteLine(contato.ToConversor());
            }
        }
    }
}
