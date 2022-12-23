using MongoDB.Bson;

namespace BlueBird.Common;

public class TwitterAccount
{
    public const int LatestSchemaVersion = 1;
    
    public ObjectId _id
    {
        get;
        set;
    }

    public int SchemaVersion
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }
    
    public string AccessToken
    {
        get;
        set;
    }

    public string AccessTokenSecret
    {
        get;
        set;
    }
}
