CREATE TRIGGER trg_AfterDeleteCategory
ON production.categories
AFTER DELETE
AS
BEGIN
    -- Ensure no rows are affected if the trigger is fired without any deletions
    IF (SELECT COUNT(*) FROM deleted) = 0
        RETURN;

    -- Log the deleted rows into an audit table (optional)
    -- Assuming you have an audit table named production.categories_audit
    INSERT INTO production.categories_audit (category_id, category_name, action, action_time)
    SELECT category_id, category_name, 'DELETE', GETDATE()
    FROM deleted;

    -- Optional: Print a message or log the deletion
    PRINT 'Rows deleted from production.categories.';
END;