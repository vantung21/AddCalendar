create database calendarDB
go

use calendarDB
go

create table users (
    id int primary key identity,
    name nvarchar(255) Not null,
    email nvarchar(255) unique

)

create table appointments (
    id int primary key identity,
    user_id int not null,
    title nvarchar(255),
    location nvarchar(255),
    start_time datetime,
    end_time datetime,
    is_group_meeting bit default 0,
    foreign key (user_id) references users(id)
)

create table members (
    id int primary key identity,
    appointment_id int,
    user_id int,
    foreign key (appointment_id) references appointments(id),
    foreign key (user_id) references users(id),
    unique (appointment_id, user_id)
)

create table reminders (
    id int primary key identity,
    appointment_id int,
    minutes_before nvarchar(255),
    foreign key (appointment_id) references appointments(id)
)



INSERT INTO users (name, email) VALUES
(N'Nguyễn Văn A', 'a@gmail.com'),
(N'Trần Văn B', 'b@gmail.com'),
(N'Lê Thị C', 'c@gmail.com'),
(N'Phạm Văn D', 'd@gmail.com'),
(N'Hoàng Văn E', 'e@gmail.com'),
(N'Võ Thị F', 'f@gmail.com'),
(N'Đặng Văn G', 'g@gmail.com'),
(N'Bùi Thị H', 'h@gmail.com'),
(N'Ngô Văn I', 'i@gmail.com'),
(N'Đỗ Thị K', 'k@gmail.com');


INSERT INTO appointments (user_id, title, location, start_time, end_time, is_group_meeting) VALUES
-- Cá nhân
(1, N'Học bài', N'Nhà', '2026-06-01 08:00', '2026-06-01 10:00', 0),
(2, N'Tập gym', N'Phòng gym', '2026-06-01 17:00', '2026-06-01 18:30', 0),
(3, N'Đọc sách', N'Thư viện', '2026-06-02 09:00', '2026-06-02 11:00', 0),

-- Group meeting
(1, N'Họp nhóm đồ án', N'Phòng A', '2026-06-03 14:00', '2026-06-03 16:00', 1),
(2, N'Hội thảo AI', N'Hội trường B', '2026-06-04 09:00', '2026-06-04 11:30', 1),
(3, N'Workshop C#', N'Lab 1', '2026-06-05 13:00', '2026-06-05 17:00', 1),
(4, N'Họp team backend', N'Phòng B', '2026-06-06 10:00', '2026-06-06 11:30', 1),
(5, N'Planning sprint', N'Phòng họp C', '2026-06-07 15:00', '2026-06-07 17:00', 1),
(6, N'Demo sản phẩm', N'Zoom', '2026-06-08 20:00', '2026-06-08 21:00', 1),
(7, N'Brainstorm ý tưởng', N'Quán cafe', '2026-06-09 18:00', '2026-06-09 20:00', 1);


INSERT INTO members (appointment_id, user_id) VALUES
-- Họp nhóm đồ án
(4,1),(4,2),(4,3),(4,4),

-- Hội thảo AI
(5,2),(5,3),(5,5),(5,6),

-- Workshop C#
(6,3),(6,4),(6,7),(6,8),

-- Backend
(7,4),(7,5),(7,6),

-- Sprint
(8,5),(8,6),(8,7),(8,8),(8,9),

-- Demo
(9,6),(9,7),(9,8),(9,10),

-- Brainstorm
(10,7),(10,8),(10,9),(10,10);




INSERT INTO reminders (appointment_id, minutes_before) VALUES
(1,'trước 30 phút'),
(2,'trước 1 giờ'),
(3,'trước 3 giờ'),
(4,'trước 12 giờ'),
(5,'trước 1 ngày'),
(6,'trước 2 ngày'),
(7,'trước 30 phút'),
(8,'trước 30 phút'),
(9,'trước 30 phút'),
(10,'trước 30 phút');



SELECT @@SERVERNAME;

EXEC sp_changedbowner 'sa';
GO