CREATE TABLE production.categories_audit
(
    audit_id INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    category_id INT NOT NULL,              -- ID of the deleted category
    category_name NVARCHAR(150) NOT NULL,  -- Name of the deleted category
    action NVARCHAR(50) NOT NULL,          -- Action performed (e.g., 'DELETE')
    action_time DATETIME NOT NULL          -- Timestamp of the action
);