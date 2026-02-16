using Moq;
using StudentScoreAPI.Controllers;
using StudentScoreAPI.Models;
using StudentScoreAPI.Repositories;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace StudentScoreAPI.Tests
{
    public class StudentsControllerTests
    {
        private readonly Mock<IStudentRepository> _mockRepo;
        private readonly StudentsController _controller;

        public StudentsControllerTests()
        {
            _mockRepo = new Mock<IStudentRepository>();
            _controller = new StudentsController(_mockRepo.Object);
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult_WithListOfStudents()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Test 1", Email = "test1@test.com", Cpf = 12345678901 },
                new Student { Id = 2, Name = "Test 2", Email = "test2@test.com", Cpf = 98765432101 }
            };
            _mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(students);

            // Act
            var result = await _controller.GetAll();

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedStudents = Assert.IsAssignableFrom<IEnumerable<Student>>(actionResult.Value);
            Assert.Equal(2, returnedStudents.Count());
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_WhenStudentDoesNotExist()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync((Student)null);

            // Act
            var result = await _controller.GetById(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task Create_ReturnsCreatedAtAction()
        {
            // Arrange
            var student = new Student { Id = 1, Name = "New Student", Email = "new@test.com", Cpf = 11122233344 };
            _mockRepo.Setup(repo => repo.AddAsync(student)).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.Create(student);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            Assert.Equal("GetById", createdAtActionResult.ActionName);
            Assert.Equal(student.Id, createdAtActionResult.RouteValues["id"]);
        }
    }
}
