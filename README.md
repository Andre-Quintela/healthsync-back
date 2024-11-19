Configurações de conexão do banco:
"Host=localhost;Port=5432;Database=healthsync;Username=postgres;Password=123"
Caso seja necessário altere no arquivo appsettings.json


Script de criação das tabelas:

```bash
CREATE TABLE IF NOT EXISTS "Users" (
    id SERIAL PRIMARY KEY, -- ID único para cada usuário
    first_name VARCHAR(100) NOT NULL, -- Primeiro nome
    last_name VARCHAR(100) NOT NULL, -- Sobrenome
    born_date DATE NOT NULL, -- Data de nascimento
    email VARCHAR(255) UNIQUE NOT NULL, -- Email único
    password VARCHAR(255) NOT NULL, -- Senha (armazenada com hash)
    address TEXT -- Endereço (pode ser nulo)
);

CREATE TABLE IF NOT EXISTS "Medicos" (
    id SERIAL PRIMARY KEY, -- ID único para cada médico
    name VARCHAR(255) NOT NULL -- Nome do médico
);

CREATE TABLE IF NOT EXISTS "Consultas" (
    id SERIAL PRIMARY KEY,  -- ID único para cada consulta
    user_name VARCHAR(100) NOT NULL,  -- Nome do paciente
    medico_nome VARCHAR(100) NOT NULL,  -- Nome do médico
    data DATE NOT NULL,  -- Data da consulta
    hora VARCHAR(5) NOT NULL  -- Hora da consulta (HH:mm)
);
```
