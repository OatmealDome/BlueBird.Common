using MongoDB.Bson;

namespace BlueBird.Common;

public class QueuedTweet
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

    public string Text
    {
        get;
        set;
    }
}
