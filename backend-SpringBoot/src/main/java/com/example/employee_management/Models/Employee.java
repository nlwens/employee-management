package com.example.employee_management.Models;

import jakarta.persistence.*;
import jakarta.validation.constraints.*;
import lombok.*;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Employee {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @NotBlank(message = "First name is required!")
    @Column(nullable = false)
    private String firstName;

    @NotBlank(message = "Last name is required!")
    @Column(nullable = false)
    private String lastName;

    @NotBlank(message = "Phone number is required!")
    @Column(nullable = false)
    private String phone;

    @NotBlank(message = "E-mail is required!")
    @Email(message = "Invalid e-mail address!")
    @Column(nullable = false, unique = true)
    private String email;

    @NotBlank(message = "Position is required!")
    @Column(nullable = false)
    private String position;

    @Version
    @Column(nullable = false)
    private Long version = 0L;
}