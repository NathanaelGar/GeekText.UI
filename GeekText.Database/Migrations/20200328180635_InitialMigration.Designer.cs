﻿// <auto-generated />
using System;
using GeekText.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GeekText.Database.Migrations
{
    [DbContext(typeof(DbContextApplication))]
    [Migration("20200328180635_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GeekText.Domain.Models.Author", b =>
                {
                    b.Property<int>("author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("author_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("bio")
                        .HasColumnName("bio")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("photograph_url")
                        .HasColumnName("photograph_url")
                        .HasColumnType("text");

                    b.HasKey("author_id")
                        .HasName("pk_authors");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("date")
                        .HasColumnName("date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<bool>("featured")
                        .HasColumnName("featured")
                        .HasColumnType("boolean");

                    b.Property<int>("genre_id")
                        .HasColumnName("genre_id")
                        .HasColumnType("integer");

                    b.Property<string>("img_url")
                        .IsRequired()
                        .HasColumnName("img_url")
                        .HasColumnType("text");

                    b.Property<double>("price")
                        .HasColumnName("price")
                        .HasColumnType("double precision");

                    b.Property<double>("rating")
                        .HasColumnName("rating")
                        .HasColumnType("double precision");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("text");

                    b.Property<bool>("top_seller")
                        .HasColumnName("top_seller")
                        .HasColumnType("boolean");

                    b.HasKey("id")
                        .HasName("pk_books");

                    b.ToTable("books");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Book_Author", b =>
                {
                    b.Property<int>("author_id")
                        .HasColumnName("author_id")
                        .HasColumnType("integer");

                    b.Property<int>("book_id")
                        .HasColumnName("book_id")
                        .HasColumnType("integer");

                    b.HasKey("author_id", "book_id")
                        .HasName("pk_book_author");

                    b.ToTable("book_author");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Book_Publisher", b =>
                {
                    b.Property<int>("publisher_id")
                        .HasColumnName("publisher_id")
                        .HasColumnType("integer");

                    b.Property<int>("book_id")
                        .HasColumnName("book_id")
                        .HasColumnType("integer");

                    b.HasKey("publisher_id", "book_id")
                        .HasName("pk_book_publishers");

                    b.ToTable("book_publishers");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int>("quantity_items")
                        .HasColumnName("quantity_items")
                        .HasColumnType("integer");

                    b.Property<decimal>("total_cost")
                        .HasColumnName("total_cost")
                        .HasColumnType("numeric");

                    b.Property<int?>("user_id")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("id")
                        .HasName("pk_carts");

                    b.HasIndex("user_id")
                        .HasName("ix_carts_user_id");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Cart_Book", b =>
                {
                    b.Property<int?>("book_id")
                        .IsRequired()
                        .HasColumnName("book_id")
                        .HasColumnType("integer");

                    b.Property<int?>("cart_id")
                        .IsRequired()
                        .HasColumnName("cart_id")
                        .HasColumnType("integer");

                    b.Property<bool>("saved_for_later")
                        .HasColumnName("saved_for_later")
                        .HasColumnType("boolean");

                    b.HasIndex("book_id")
                        .HasName("ix_cart_books_book_id");

                    b.HasIndex("cart_id")
                        .HasName("ix_cart_books_cart_id");

                    b.ToTable("cart_books");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Genre", b =>
                {
                    b.Property<int>("genre_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("genre_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("genre_id")
                        .HasName("pk_genres");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int>("cart_id")
                        .HasColumnName("cart_id")
                        .HasColumnType("integer");

                    b.Property<int>("payment_id")
                        .HasColumnName("payment_id")
                        .HasColumnType("integer");

                    b.Property<int>("user_id")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("id")
                        .HasName("pk_orders");

                    b.HasIndex("cart_id")
                        .HasName("ix_orders_cart_id");

                    b.HasIndex("payment_id")
                        .HasName("ix_orders_payment_id");

                    b.HasIndex("user_id")
                        .HasName("ix_orders_user_id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Payment_Method", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("card_nickname")
                        .IsRequired()
                        .HasColumnName("card_nickname")
                        .HasColumnType("text");

                    b.Property<int>("card_number")
                        .HasColumnName("card_number")
                        .HasColumnType("integer");

                    b.Property<int>("cvv")
                        .HasColumnName("cvv")
                        .HasColumnType("integer");

                    b.Property<string>("expiration")
                        .IsRequired()
                        .HasColumnName("expiration")
                        .HasColumnType("text");

                    b.HasKey("id")
                        .HasName("pk_payment_methods");

                    b.ToTable("payment_methods");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Publisher", b =>
                {
                    b.Property<int>("publisher_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("publisher_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("publisher_id")
                        .HasName("pk_publishers");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("GeekText.Domain.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'1000', '1', '', '', 'False', '1'")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("home_address")
                        .IsRequired()
                        .HasColumnName("home_address")
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("nickname")
                        .IsRequired()
                        .HasColumnName("nickname")
                        .HasColumnType("text");

                    b.Property<int>("user_nickname")
                        .HasColumnName("user_nickname")
                        .HasColumnType("integer");

                    b.Property<string>("user_password")
                        .IsRequired()
                        .HasColumnName("user_password")
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnName("username")
                        .HasColumnType("text");

                    b.HasKey("id")
                        .HasName("pk_users");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Wishlist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<bool>("primary")
                        .HasColumnName("primary")
                        .HasColumnType("boolean");

                    b.Property<int>("user_id")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("id")
                        .HasName("pk_wishlists");

                    b.HasIndex("user_id")
                        .HasName("ix_wishlists_user_id");

                    b.ToTable("wishlists");
                });

            modelBuilder.Entity("GeekText.Domain.Models.WishlistBook", b =>
                {
                    b.Property<int>("wishlist_id")
                        .HasColumnName("wishlist_id")
                        .HasColumnType("integer");

                    b.Property<int>("book_id")
                        .HasColumnName("book_id")
                        .HasColumnType("integer");

                    b.HasKey("wishlist_id", "book_id")
                        .HasName("pk_wishlists_books");

                    b.HasIndex("book_id")
                        .HasName("ix_wishlists_books_book_id");

                    b.ToTable("wishlists_books");
                });

            modelBuilder.Entity("GeekText.Domain.Models.Cart", b =>
                {
                    b.HasOne("GeekText.Domain.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .HasConstraintName("fk_carts_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeekText.Domain.Models.Cart_Book", b =>
                {
                    b.HasOne("GeekText.Domain.Models.Book", "book")
                        .WithMany()
                        .HasForeignKey("book_id")
                        .HasConstraintName("fk_cart_books_books_book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeekText.Domain.Models.Cart", "cart")
                        .WithMany()
                        .HasForeignKey("cart_id")
                        .HasConstraintName("fk_cart_books_carts_cart_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeekText.Domain.Models.Order", b =>
                {
                    b.HasOne("GeekText.Domain.Models.Cart", "cart")
                        .WithMany()
                        .HasForeignKey("cart_id")
                        .HasConstraintName("fk_orders_carts_cart_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeekText.Domain.Models.Payment_Method", "payment_method")
                        .WithMany()
                        .HasForeignKey("payment_id")
                        .HasConstraintName("fk_orders_payment_methods_payment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeekText.Domain.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .HasConstraintName("fk_orders_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeekText.Domain.Models.Wishlist", b =>
                {
                    b.HasOne("GeekText.Domain.Models.User", "user")
                        .WithMany("wishlists")
                        .HasForeignKey("user_id")
                        .HasConstraintName("fk_wishlists_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GeekText.Domain.Models.WishlistBook", b =>
                {
                    b.HasOne("GeekText.Domain.Models.Book", "book")
                        .WithMany("wishlist_books")
                        .HasForeignKey("book_id")
                        .HasConstraintName("fk_wishlists_books_books_book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeekText.Domain.Models.Wishlist", "wishlist")
                        .WithMany("wishlist_books")
                        .HasForeignKey("wishlist_id")
                        .HasConstraintName("fk_wishlists_books_wishlists_wishlist_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}