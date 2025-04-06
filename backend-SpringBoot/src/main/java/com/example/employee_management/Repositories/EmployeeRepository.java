package com.example.employee_management.Repositories;

import com.example.employee_management.Models.Employee;
import org.springframework.data.jpa.repository.JpaRepository;


public interface EmployeeRepository extends JpaRepository<Employee, Integer> {
}
