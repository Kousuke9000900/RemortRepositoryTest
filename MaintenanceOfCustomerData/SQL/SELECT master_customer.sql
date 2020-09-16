SELECT
    id
,   name
,   branch_name
,   postal_code
,   telephone_number
,   address
,   remark
FROM
    master_customer
WHERE
    name LIKE '%{0}%'
AND branch_name LIKE '%{1}%'