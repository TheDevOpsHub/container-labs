# Manage file permission

## Linux File Permissions: Core Concepts

Understanding Linux file permissions requires grasping these fundamental concepts:

### 1. The Permission Triad

Every file and directory has three permission types for three user classes, creating a 3x3 matrix:

```
User Classes:   Owner   Group   Others
Permissions:    rwx     rwx     rwx
```

### 2. Permission Types Explained

| Symbol | Permission | Files                          | Directories                     |
|--------|------------|--------------------------------|----------------------------------|
| **r**  | Read       | View file contents             | List directory contents (ls)     |
| **w**  | Write      | Modify/delete file             | Create/delete files in directory |
| **x**  | Execute    | Run as program/script          | Enter directory (cd)             |

### 3. User Classes Defined

1. **Owner (u)**: The user who created the file
   - Typically has the most permissions
   - Changed with `chown`

2. **Group (g)**: All users belonging to the file's group
   - Useful for team collaboration
   - Changed with `chown` or `chgrp`

3. **Others (o)**: All other users on the system
   - Represents "world" permissions
   - Often has minimal permissions for security

### 4. Permission Representation

Linux represents permissions in two ways:

**Symbolic Notation:**
```
-rwxr-xr--
```
- First character: file type (`-` regular, `d` directory, `l` symlink)
- Next 9 characters: permissions (3 sets of 3)

**Numeric (Octal) Notation:**
```
Permissions: rwx r-x r--
Binary:      111 101 100
Octal:       7   5   4   → 754
```

### 5. Special Permission Bits

Three additional permission bits extend the basic model:

1. **Set User ID (SUID - 4000)**
   - Files execute as the owner's privileges
   - Shows as `s` in owner's execute position (`rwsr-xr-x`)

2. **Set Group ID (SGID - 2000)**
   - Files execute with group's privileges
   - Directories: new files inherit group ownership
   - Shows as `s` in group's execute position (`rwxr-sr-x`)

3. **Sticky Bit (1000)**
   - On directories: only owner can delete files
   - Shows as `t` in others' execute position (`rwxrwxrwt`)
   - Critical for shared directories like `/tmp`

### 6. Default Permissions (umask)

The `umask` determines default permissions for new files:
- Subtracted from full permissions (666 for files, 777 for directories)
- Common values: 022 (results in 644/755) or 077 (600/700)

View current umask:
```bash
umask
```

Set new umask:
```bash
umask 027
```

### 7. Permission Inheritance

Key behaviors:
- New files inherit the creating process's umask
- New directories inherit parent's SGID bit if set
- Copied files receive new permissions based on umask
- Moved files retain their original permissions

### 8. Security Implications

Critical permission principles:
1. **Principle of Least Privilege**: Grant minimum necessary access
2. **Regular Audits**: Check for world-writable files (`find / -perm -o+w`)
3. **Special Bit Caution**: SUID/SGID can create security holes
4. **Home Directories**: Should typically be 700 (drwx------)
5. **System Files**: Should generally be owned by root with restrictive permissions

## Start the lab
TBD