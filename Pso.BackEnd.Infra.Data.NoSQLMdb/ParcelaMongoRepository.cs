﻿using PSO.BackEnd.Domain.Entities;
using PSO.BackEnd.Domain.Interfaces.Repositories.NoSQLMdb;
using PSO.BackEnd.Domain.Interfaces.Repositories.NoSQLMdb.Read;
using PSO.BackEnd.Domain.Interfaces.Repositories.NoSQLMdb.Write;

namespace Pso.BackEnd.Infra.Data.NoSQLMdb
{
    public class ParcelaMongoRepository : MongoRepository<Parcela>, IParcelaWriteMongoRepository, IParcelaReadMongoRepository
    {
        public ParcelaMongoRepository(IPsoDbMongoDatabaseSettings settings) : base(settings)
        {
        }
    }
}