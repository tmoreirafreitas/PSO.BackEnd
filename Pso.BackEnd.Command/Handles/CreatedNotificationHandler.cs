﻿using MediatR;
using Pso.BackEnd.Command.Notifications;
using PSO.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pso.BackEnd.Command.Handles
{
    public class CreatedNotificationHandler<T> : INotificationHandler<CreatedCommand<T>> where T : Entity
    {
        public Task Handle(CreatedCommand<T> notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}