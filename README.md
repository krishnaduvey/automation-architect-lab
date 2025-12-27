# AutomationArchitectLab

Enterprise-grade API Automation Platform built in C# using layered architecture.

## Architecture Highlights

- Centralized ExecutionGuard controlling retries, logging and observability
- Parallel-safe TestContext using AsyncLocal
- Intelligent retry policies based on failure classification
- Domain-driven service layer abstraction
- Contract-first request/response modeling
- CI-stable resilient execution design

## Suitable For

- Enterprise API automation
- Contract validation platforms
- BDD / SpecFlow based pipelines
- Platform QA engineering teams

## Key Capabilities

✔ Contract-first automation  
✔ Centralized execution orchestration  
✔ Retry & resiliency  
✔ Parallel-safe context handling  
✔ Domain-driven API services  
✔ Enterprise validation layer  

Core
 ├─ Context        (Parallel-safe execution state)
 ├─ Execution      (ExecutionGuard, FailurePolicy)
 ├─ Retry          (Resiliency engine)
 ├─ Metrics        (Observability & performance)
 ├─ Http           (Central API engine)

Contracts
 ├─ Requests
 ├─ Responses
 └─ Enums

Services
 └─ Domain API Engines

Tests
 ├─ Base
 ├─ Validators
 └─ Scenarios


Built by: Krishan (Automation Architect)
