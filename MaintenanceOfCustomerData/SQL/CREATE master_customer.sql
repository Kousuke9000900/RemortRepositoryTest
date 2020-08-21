CREATE TABLE IF NOT EXISTS master_customer(
    id                  SMALLINT        NOT NULL PRIMARY KEY    --取引先ID
,   name                VARCHAR(40)     NOT NULL                --取引先名
,   branch_name         VARCHAR(40)     NOT NULL                --取引先支店名
,   postal_code         VARCHAR(8)      NOT NULL                --取引先郵便番号
,   telephone_number    VARCHAR(13)     NOT NULL                --取引先電話番号
,   address             VARCHAR(40)     NOT NULL                --取引先住所
,   remark              VARCHAR(40)     NOT NULL                --取引先備考
,   created_at          DATETIME        NOT NULL                --取引先情報作成日時
,   created_by          VARCHAR(16)     NOT NULL                --取引先情報作成者
,   updated_at          DATETIME        NOT NULL                --取引先情報更新日時
,   updated_by          VARCHAR(16)     NOT NULL                --取引先情報更新者
)
