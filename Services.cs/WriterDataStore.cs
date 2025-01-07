using API_rest.Data;

namespace API_rest.services;

public class WriterDataStore
{
    public List<clWritter> Writers {get; set;}
    public static WriterDataStore Current {get;} = new WriterDataStore();
    public WriterDataStore()
    {
        Writers = new List<clWritter>()
        {
            new clWritter(){
                IdWriter_prop = 8,
                Nickname_prop = "unsolicited_yao",
                Style_prop = "WildStyle",
                Nationality_prop = "Costarricense"
            },
            new clWritter(){
                IdWriter_prop = 14,
                Nickname_prop = "SLO",
                Style_prop = "BlockBuster",
                Nationality_prop = "CDMX"
            },
                new clWritter(){
                IdWriter_prop = 16,
                Nickname_prop = "DPR",
                Style_prop = "ThrowUp",
                Nationality_prop = "Colombia"

        }
    };

    }
}
