﻿namespace PetShop.Desktop.Constants;

public class DbConstants
{
    public const string DB_HOST = "localhost";
    public const string DB_PORT = "5432";
    public const string DB_DATABASE = "pet_shop_db";
    public const string DB_USER = "postgres";
    public const string DB_PASSWORD = "@20112606";

    public const string DB_CONNECTIONSTRING = $"Host={DB_HOST};" +
        $"Port={DB_PORT};" +
        $"Database={DB_DATABASE};" +
        $"User ID={DB_USER};" +
        $"Password={DB_PASSWORD}";
}
