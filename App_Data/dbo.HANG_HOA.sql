CREATE TABLE [dbo].[HANG_HOA] (
    [MA_HANG]      VARCHAR (10)    NOT NULL,
    [TEN_HANG]     NVARCHAR (50)   NOT NULL,
    [MA_LOAI_HANG] VARCHAR (10)    NOT NULL,
    [MA_NSX]       VARCHAR (10)    NULL,
    [MA_NCC]       VARCHAR (10)    NULL,
    [MA_QGSX]      VARCHAR (10)    NULL,
    [MA_QGTK]      VARCHAR (10)    NULL,
    [GIA_BAN]      INT             NOT NULL,
    [GIA_NHAP]     INT             NOT NULL,
    [PT_GIAMGIA]   INT             NOT NULL,
    [THONG_SO]     NVARCHAR (1000) NOT NULL,
    [HINH_ANH]     VARCHAR (128)   NOT NULL,
    PRIMARY KEY CLUSTERED ([MA_HANG] ASC)
);

