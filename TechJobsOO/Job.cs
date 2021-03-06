﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public string Value { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName,Location employerlocation, PositionType jobType, CoreCompetency jobCoreCompetency ) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerlocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;


            

        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override string ToString()
        {
            string dna = "Data not Available";
            string empN = EmployerName.Value;
            string local = EmployerLocation.Value;
            string posTy = JobType.Value;
            string coreC = JobCoreCompetency.Value;

            return $" ID: {Id}\n Name: {(!string.IsNullOrEmpty(Name) ? Name : dna) } \n Employer: {(!string.IsNullOrEmpty(empN) ? empN : dna)} \n Location: {(!string.IsNullOrEmpty(local) ? local :dna)} \n Position Type: {(!string.IsNullOrEmpty(posTy) ? posTy : dna)} \n Core Competency: {(!string.IsNullOrEmpty(coreC) ? coreC :dna)}";
        }
        public override bool Equals(object obj)
        {
            return obj is Job employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
