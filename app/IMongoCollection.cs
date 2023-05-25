using MongoDB.Bson;

namespace app
{
    internal interface IMongoCollection
    {
        List<BsonDocument> Find();
    }
}