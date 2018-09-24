﻿// <auto-generated />
using System;
using CodeProject.LoggingManagement.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeProject.LoggingManagement.Data.EntityFramework.Migrations
{
    [DbContext(typeof(LoggingManagementDatabase))]
    [Migration("20180922140445_ackqueue")]
    partial class ackqueue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeProject.LoggingManagement.Data.Entities.AcknowledgementsQueue", b =>
                {
                    b.Property<int>("AcknowledgementsQueueId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcknowledgementQueue");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ExchangeName");

                    b.Property<int>("SenderTransactionQueueId");

                    b.Property<string>("TransactionCode");

                    b.HasKey("AcknowledgementsQueueId");

                    b.ToTable("AcknowledgementsQueue");
                });

            modelBuilder.Entity("CodeProject.LoggingManagement.Data.Entities.MessagesReceived", b =>
                {
                    b.Property<int>("MessagesReceivedId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ExchangeName");

                    b.Property<string>("Payload");

                    b.Property<string>("QueueName");

                    b.Property<int>("SenderTransactionQueueId");

                    b.Property<string>("TransactionCode");

                    b.HasKey("MessagesReceivedId");

                    b.ToTable("MessagesReceived");
                });

            modelBuilder.Entity("CodeProject.LoggingManagement.Data.Entities.MessagesSent", b =>
                {
                    b.Property<int>("MessagesSentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcknowledgementsReceived");

                    b.Property<int>("AcknowledgementsRequired");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("ExchangeName");

                    b.Property<string>("Payload");

                    b.Property<int>("SenderTransactionQueueId");

                    b.Property<string>("TransactionCode");

                    b.HasKey("MessagesSentId");

                    b.ToTable("MessagesSent");
                });

            modelBuilder.Entity("CodeProject.LoggingManagement.Data.Entities.TransactionQueueSemaphore", b =>
                {
                    b.Property<int>("TransactionQueueSemaphoreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("SemaphoreKey");

                    b.HasKey("TransactionQueueSemaphoreId");

                    b.HasIndex("SemaphoreKey")
                        .IsUnique()
                        .HasFilter("[SemaphoreKey] IS NOT NULL");

                    b.ToTable("TransactionQueueSemaphores");
                });
#pragma warning restore 612, 618
        }
    }
}
