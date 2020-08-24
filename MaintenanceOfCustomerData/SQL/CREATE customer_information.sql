CREATE TABLE IF NOT EXISTS customer_information(                                            --取引先情報
    customer_id         smallint    FOREIGN KEY REFERENCES  master_customer(id) PRIMARY KEY --取引先ID
,   industry            VARCHAR(40)     NOT NULL                                            --業種
,   handling_product    VARCHAR(40)     NOT NULL                                            --取扱商品
,   remark              VARCHAR(40)     NOT NULL                                            --取引先情報備考
,   created_at          DATETIME        NOT NULL                                            --取引先情報作成日時
,   created_by          VARCHAR(16)     NOT NULL                                            --取引先情報作成者
,   updated_at          DATETIME        NOT NULL                                            --取引先情報更新日時
,   updated_by          VARCHAR(16)     NOT NULL                                            --取引先情報更新者
)
