# Security policy

## Reporting a vulnerability

Do not report suspected vulnerabilities or exposed credentials in a public
issue.

Use GitHub private vulnerability reporting for this repository. Include the
affected version, reproduction details, impact, and any suggested mitigation.
Please allow time to investigate before publicly disclosing the report.

## Credential handling

ACMP does not store Marketplace credentials. Applications and scripts are
responsible for obtaining credentials from an appropriate secret store and
passing them to the client at runtime.

If a credential or session token is accidentally committed, revoke it
immediately and report the exposure privately. Removing the value from the
latest revision does not remove it from Git history.
