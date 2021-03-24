using DynamoDB.Libs.DynamoDB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSDynamoDB.Controllers
{
    public class DynamoDBController : BaseController
    {
        #region Properties
        private readonly IDynamoDBExample _dynamoDBExample;
        #endregion

        #region Constr
        public DynamoDBController(IDynamoDBExample dynamoDBExample) {
            this._dynamoDBExample = dynamoDBExample;
        }
        #endregion

        #region Methods
        [HttpGet("CreateTable")]
        public async Task<IActionResult> CreateDynamoDBTable()
        {
            await this._dynamoDBExample.CreateDynamoDBTable();
            return Ok();
        }
        #endregion
    }
}
