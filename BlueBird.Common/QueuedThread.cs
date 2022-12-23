using MongoDB.Bson;

namespace BlueBird.Common;

public class QueuedThread
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

    public ObjectId TargetAccount
    {
        get;
        set;
    }

    public DateTime PostTime
    {
        get;
        set;
    }

    public List<ObjectId> Tweets
    {
        get;
        set;
    }

    public bool IsPosted
    {
        get;
        set;
    }
}
